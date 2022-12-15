using LifeGaurd.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Interfaces
{
    public interface IUser
    {
        Task<DbSet<User>> GetAllAsync();
        Task<User> GetByIdAsync(int Id);
        
        Task<User> AddAsync(int UserId,string UserName,string Phone,string Adress,string Email,string IPAdress, Pool Pool);
        Task<User> UpdateAsync(User u);
        Task DeleteAsync(int id);
    }
}
