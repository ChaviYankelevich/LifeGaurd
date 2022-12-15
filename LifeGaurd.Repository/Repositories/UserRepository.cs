using LifeGaurd.Repositories.Entities;
using LifeGaurd.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Repositories
{
    public class UserRepository : IUser
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }
        public Task<User> AddAsync(int UserId, string UserName, string Phone, string Adress, string Email, string IPAdress, Pool Pool)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DbSet<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(User u)
        {
            throw new NotImplementedException();
        }
    }
}
