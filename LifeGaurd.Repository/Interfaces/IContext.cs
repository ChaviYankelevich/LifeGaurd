using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LifeGaurd.Repositories.Entities;

namespace LifeGaurd.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Tracker> Trackers { get; set; }
        DbSet<Pool> Pools { get; set; }
        DbSet<Contour> Contours { get; set; }
        Task<int> SaveChangesAsync();
    }
}
