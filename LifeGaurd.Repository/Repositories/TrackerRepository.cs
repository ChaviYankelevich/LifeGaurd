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
    public class TrackerRepository : ITracker
    {
        private readonly IContext _context;

        public TrackerRepository(IContext context)
        {
            _context = context;
        }

        public Task<Tracker> AddAsync(int TrackerId, Pool Pool, Contour TrackerCourter, EStatus Status)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DbSet<Tracker>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tracker> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Tracker> UpdateAsync(Tracker u)
        {
            throw new NotImplementedException();
        }
    }
}
