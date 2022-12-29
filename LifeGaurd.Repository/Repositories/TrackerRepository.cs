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
    public class TrackerRepository : ITrackeRepositoryr
    {
        private readonly IContext _context;

        public TrackerRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Tracker> AddAsync(int TrackerId, Pool Pool, Contour TrackerCourter, EStatus Status)
        {
            var added = _context.Trackers.Add(new Tracker { TrackerId = TrackerId, TrackerCourter=TrackerCourter, Status = Status });
            await _context.SaveChangesAsync();
            return added.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            Tracker t = _context.Trackers.ToList<Tracker>().Find(r => r.TrackerId == id);
            _context.Trackers.Remove(t);
            await _context.SaveChangesAsync();
        }

        public async Task<DbSet<Tracker>> GetAllAsync()
        {
            await _context.SaveChangesAsync();
            return _context.Trackers;
        }

        public async Task<Tracker> GetByIdAsync(int Id)
        {
            await _context.SaveChangesAsync();
            return _context.Trackers.ToList<Tracker>().Find(r => r.TrackerId == Id);
        }

        public async Task<Tracker> UpdateAsync(Tracker t)
        {
            _context.Trackers.ToList<Tracker>().Find(r => r.TrackerId == t.TrackerId).Pool = t.Pool;
            _context.Trackers.ToList<Tracker>().Find(r => r.TrackerId == t.TrackerId).TrackerCourter = t.TrackerCourter;
            _context.Trackers.ToList<Tracker>().Find(r => r.TrackerId == t.TrackerId).Status = t.Status;
            
            await _context.SaveChangesAsync();
            return t;
        }
    }
}
