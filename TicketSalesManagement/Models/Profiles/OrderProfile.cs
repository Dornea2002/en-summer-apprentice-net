using AutoMapper;
using TicketSalesManagement.Models.Dto;

namespace TicketSalesManagement.Models.Profiles
{
    public class OrderProfile :Profile
    {
        public OrderProfile() {
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, OrderPatchDto>().ReverseMap();
        }
    }
}
