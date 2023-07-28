using Microsoft.EntityFrameworkCore;
using TicketManagement.Models;

namespace TicketManagement.Repository
{
    public class TicketCategoryRepository : ITicketCategoryRepository
    {
        private readonly TicketSalesManagementContext _dbContext;
        public TicketCategoryRepository() {
            _dbContext = new TicketSalesManagementContext();
        }

        public async Task<TicketCategory> GetById(int id)
        {
            var @ticketCategory = await _dbContext.TicketCategories.Where(t => t.TicketCategoryid == id).FirstOrDefaultAsync();
            return @ticketCategory;
        }
    }
}
