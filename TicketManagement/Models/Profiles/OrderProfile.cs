using AutoMapper;
using System.Runtime.InteropServices;
using TicketManagement.Models.Dto;

namespace TicketManagement.Models.Profiles
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, OrderPatchDto>().ReverseMap();
        }
    }
}
