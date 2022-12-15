using LifeGaurd.Repositories.Entities;
using LifeGaurd.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Repositories
{
    public class ContourRepository : IcontourRepository
    {
        private readonly IContext _context;

        public ContourRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Contour> AddAsync(int ContourId, int W, int X, int Y, int Z)
        {            
            var added = _context.Contours.Add(new Contour { ContourId = ContourId, W = W, X=X, Y=Y,Z=Z });
            await _context.SaveChangesAsync();
            return added.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            Contour c = _context.Contours.ToList<Contour>().Find(r => r.ContourId == id);
            _context.Contours.Remove(c);
            await _context.SaveChangesAsync();
        }

        public async Task<DbSet<Contour>> GetAllAsync()
        {
            await _context.SaveChangesAsync();
            return _context.Contours;
        }

        public async Task<Contour> GetByIdAsync(int Id)
        {
            await _context.SaveChangesAsync();
            return _context.Contours.ToList<Contour>().Find(r => r.ContourId == Id);
        }

        public async Task<Contour> UpdateAsync(Contour c)
        {
            _context.Contours.ToList<Contour>().Find(r => r.ContourId == c.ContourId).W = c.W;
            _context.Contours.ToList<Contour>().Find(r => r.ContourId == c.ContourId).X = c.X;
            _context.Contours.ToList<Contour>().Find(r => r.ContourId == c.ContourId).Y = c.Y;
            _context.Contours.ToList<Contour>().Find(r => r.ContourId == c.ContourId).Z = c.Z;
            await _context.SaveChangesAsync();
            return c;
        }
    }
}
