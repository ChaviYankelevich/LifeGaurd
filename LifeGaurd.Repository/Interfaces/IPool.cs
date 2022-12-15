using LifeGaurd.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Interfaces
{
    public interface IPool
    {
        Task<DbSet<Pool>> GetAllAsync();
        Task<Pool> GetByIdAsync(int Id);
        Task<Pool> AddAsync(int PoolId, User User, int WaterContour);       
        Task<Pool> UpdateAsync(Pool u);
        Task DeleteAsync(int id);
    }
}
