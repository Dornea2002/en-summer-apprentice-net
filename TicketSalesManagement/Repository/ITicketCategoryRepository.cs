﻿using TicketSalesManagement.Models;

namespace TicketSalesManagement.Repository
{
    public interface ITicketCategoryRepository
    {
        IEnumerable<TicketCategory> GetAll();
        Task<TicketCategory> GetById(int id);
        int Add(TicketCategory @ticketCategory);
        void Update(TicketCategory @ticketCategory);
        void Delete(TicketCategory @ticketCategory);
    }
}
