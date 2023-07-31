using AutoMapper;
using TicketSalesManagement.Models.Dto;

namespace TicketSalesManagement.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserPatchDto>().ReverseMap();
        }
    }
}
