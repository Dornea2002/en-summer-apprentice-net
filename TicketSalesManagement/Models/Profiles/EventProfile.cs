using AutoMapper;
using TicketSalesManagement.Models.Dto;

namespace TicketSalesManagement.Models.Profiles
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventDto>().ForMember(dest => dest.TicketCategories, opt => opt.MapFrom(src => src.TicketCategories));
            CreateMap<Event, EventPatchDto>();
            CreateMap<TicketCategory, TicketCategoryDto>();
        }
    }
}
