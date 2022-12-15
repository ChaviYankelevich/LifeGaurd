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
    public class PoolRepository : IPoolRepository
    {
        private readonly IContext _context;

        public PoolRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Pool> AddAsync(int PoolId, User User, int WaterContour)
        {
            var added = _context.Pools.Add(new Pool { PoolId = PoolId,User=User,WaterContour=WaterContour  });
            await _context.SaveChangesAsync();
            return added.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            Pool c = _context.Pools.ToList<Pool>().Find(r => r.PoolId == id);
            _context.Pools.Remove(c);
            await _context.SaveChangesAsync();
        }

        public async Task<DbSet<Pool>> GetAllAsync()
        {
            await _context.SaveChangesAsync();
            return _context.Pools;
        }

        public async Task<Pool> GetByIdAsync(int Id)
        {
            await _context.SaveChangesAsync();
            return _context.Pools.ToList<Pool>().Find(r => r.PoolId == Id);
        }

        public async Task<Pool> UpdateAsync(Pool p)
        {
            _context.Pools.ToList<Pool>().Find(r => r.PoolId == p.PoolId).User = p.User;
            _context.Pools.ToList<Pool>().Find(r => r.PoolId == p.PoolId).WaterContour = p.WaterContour;
            await _context.SaveChangesAsync();
            return p;
        }
    }
}
