using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using TicketManagement.Models;
using TicketManagement.Models.Dto;
using TicketManagement.Models.DTO;
using TicketManagement.Repository;

namespace TicketManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly ITicketCategoryRepository _ticketCategoryRepository;

        public OrderController(IMapper mapper, IOrderRepository orderRepository, ITicketCategoryRepository ticketCategoryRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _ticketCategoryRepository = ticketCategoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetAll()
        {
            var order = _orderRepository.GetAll();

            var dtoOrder = order.Select(o=> _mapper.Map<OrderDto>(order));

            //var orderDto = _mapper.Map<OrderDto>(order);

            return Ok(dtoOrder);
        }

        [HttpGet]
        public ActionResult<OrderDto> GetById(int id) { 
            var @order = _orderRepository.GetById(id);

            if(@order == null)
            {
                return NotFound();
            }

            var orderDto = _mapper.Map<OrderDto>(@order);

            return Ok(orderDto);
        }

        [HttpPatch]
        public async Task<ActionResult<OrderPatchDto>> Patch(OrderPatchDto orderPatch)
        {
            var orderEntity = await _orderRepository.GetById(orderPatch.Orderid);
            if (orderEntity == null)
            {
                return NotFound();
            }



            if (orderPatch.TicketCategoryid != 0)
            {
                var ticketCategory = await _ticketCategoryRepository.GetById((int)orderPatch.TicketCategoryid);

                if (ticketCategory == null)
                {
                    return NotFound("Ticket category not found");
                }



                double totalPrice = (double)(ticketCategory.Price * orderPatch.NumberOfTickets);
                orderEntity.TotalPrice = totalPrice;
            }
            else
            {
                return NotFound("Ticket category ID is missing or invalid");
            }



            _mapper.Map(orderPatch, orderEntity);
            _orderRepository.Update(orderEntity);
            return Ok(orderEntity);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var orderEntity= await _orderRepository.GetById(id);

            if(orderEntity == null)
            {
                NotFound();
            }

            _orderRepository.Delete(orderEntity);
            return NoContent();
        }
    }
}
