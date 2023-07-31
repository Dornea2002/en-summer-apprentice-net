using TicketSalesManagement.Models.Dto;
using AutoMapper;

namespace TicketSalesManagement.Models.Profiles
{
    public class TicketCategoryProfile : Profile
    {
        public TicketCategoryProfile() {
            CreateMap<TicketCategory, TicketCategoryDto>().ReverseMap();
        }
    }
}
