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
    public class PoolRepository : IPool
    {
        private readonly IContext _context;

        public PoolRepository(IContext context)
        {
            _context = context;
        }
        public Task<Pool> AddAsync(int PoolId, User User, int WaterContour)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DbSet<Pool>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Pool> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Pool> UpdateAsync(Pool u)
        {
            throw new NotImplementedException();
        }
    }
}
