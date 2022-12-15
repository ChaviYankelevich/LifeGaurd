using LifeGaurd.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Interfaces
{
    public interface ITracker
    {
        Task<DbSet<Tracker>> GetAllAsync();
        Task<Tracker> GetByIdAsync(int Id);

        Task<Tracker> AddAsync(int TrackerId, Pool Pool, Contour TrackerCourter, EStatus Status);
        
        Task<Tracker> UpdateAsync(Tracker u);
        Task DeleteAsync(int id);
    }
}
