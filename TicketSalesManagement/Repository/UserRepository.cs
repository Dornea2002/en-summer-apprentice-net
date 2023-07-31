using Microsoft.EntityFrameworkCore;
using TicketSalesManagement.Exceptions;
using TicketSalesManagement.Models;

namespace TicketSalesManagement.Repository
{
    public class UserRepository
    {
        private readonly TicketSalesManagementContext _dbContext;

        public UserRepository()
        {
            _dbContext = new TicketSalesManagementContext();
        }

        public int Add(User @user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User @user)
        {
            _dbContext.Remove(@user);
            _dbContext.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            var users = _dbContext.Users;

            return users;
        }

        public async Task<User> GetById(int id)
        {
            var @user = await _dbContext.Users.Where(c => c.Userid == id).FirstOrDefaultAsync();

            if (@user == null)
                throw new EntityNotFound(id, nameof(User));

            return @user;
        }


        public void Update(User @user)
        {
            _dbContext.Entry(@user).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
