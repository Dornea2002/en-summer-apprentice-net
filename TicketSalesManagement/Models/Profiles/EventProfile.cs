using AutoMapper;
using TicketSalesManagement.Models.Dto;

namespace TicketSalesManagement.Models.Profiles
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventDto>().ReverseMap();
            CreateMap<Event, EventPatchDto>().ReverseMap();
        }
    }
}
