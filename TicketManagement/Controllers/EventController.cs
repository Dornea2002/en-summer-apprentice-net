using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System;
using TicketManagement.Models.DTO;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TicketManagement.Models;
using TicketManagement.Repository;
using AutoMapper;
using TicketManagement.Models.Dto;

namespace TicketManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository _eventRepository; 

        public EventController(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<EventDto>> GetAll()
        {
            var events = _eventRepository.GetAll();

            //SAU FOLOSIM LINQ:

            var dtoEvents = events.Select(e => new EventDto()
            {
                EvendID = e.Eventid,
                EventName = e.EventName ?? string.Empty,
                EventDescription = e.EventDescription ?? string.Empty,
                EventType = e.EventType?.EventTypeName ?? string.Empty, //if eventtype is null then return string empty. otherwise get eventtype
                Venue = e.Venue?.Location ?? string.Empty
            });

            return Ok(dtoEvents);
        }

        [HttpGet]
        public ActionResult<EventDto> GetById(int id)
        {
            var @event = _eventRepository.GetByID(id);

            if(@event == null)
            {
                return NotFound();
            }

            var eventDto = _mapper.Map<EventDto>(@event);

            return Ok(eventDto);
        }

        [HttpPatch]
        public async Task<ActionResult<EventPatchDto>> Patch(EventPatchDto eventPatch)
        {
            var eventEntity = await _eventRepository.GetByID(eventPatch.EventID);

            if(eventEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(eventPatch, eventEntity);
            _eventRepository.Update(eventEntity);

            return Ok(eventEntity);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var eventEntity = await _eventRepository.GetByID(id);
            if(eventEntity == null) {
                return NotFound();
            }
            _eventRepository.Delete(eventEntity);
            return NoContent(); 

        }
    }
}