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
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task<User> AddAsync(int UserId, string UserName, string Phone, string Adress, string Email, string IPAdress, Pool Pool)
        {
            var added = _context.Users.Add(new User { UserId = UserId, Phone=Phone,Adress=Adress,Email=Email,IPAdress=IPAdress,Pool=Pool });
            await _context.SaveChangesAsync();
            return added.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            User t = _context.Users.ToList<User>().Find(r => r.UserId == id);
            _context.Users.Remove(t);
            await _context.SaveChangesAsync();
        }

        public async Task<DbSet<User>> GetAllAsync()
        {
            await _context.SaveChangesAsync();
            return _context.Users;
        }

        public async Task<User> GetByIdAsync(int Id)
        {
            await _context.SaveChangesAsync();
            return _context.Users.ToList<User>().Find(r => r.UserId == Id);
        }

        public async Task<User> UpdateAsync(User u)
        {
            _context.Users.ToList<User>().Find(r => r.UserId == u.UserId).Phone = u.Phone;
            _context.Users.ToList<User>().Find(r => r.UserId == u.UserId).Adress = u.Adress;
            _context.Users.ToList<User>().Find(r => r.UserId == u.UserId).Email = u.Adress;
            _context.Users.ToList<User>().Find(r => r.UserId == u.UserId).IPAdress = u.Adress;
            _context.Users.ToList<User>().Find(r => r.UserId == u.UserId).Pool = u.Pool;
            await _context.SaveChangesAsync();
            return u;
        }
    }
}
