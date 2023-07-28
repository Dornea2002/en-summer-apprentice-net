using AutoMapper;
using TicketManagement.Models.Dto;
using TicketManagement.Models.DTO;

namespace TicketManagement.Models.Profiles
{
    public class EventProfile : Profile
    {
        public EventProfile() {
            CreateMap<Event, EventDto>().ReverseMap();
            CreateMap<Event, EventPatchDto>().ReverseMap();
        }  
    }
}
