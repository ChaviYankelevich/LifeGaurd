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
    public class ContourRepository : IContour
    {
        private readonly IContext _context;

        public ContourRepository(IContext context)
        {
            _context = context;
        }
        public Task<Contour> AddAsync(int ContourId, int W, int X, int Y, int Z)
        {            
            var added = _context.Contours.Add(new Contour { ContourId = ContourId, W = W, X=X, Y=Y,Z=Z });
            await _context.SaveChangesAsync();
            return added.Entity;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DbSet<Entities.Contour>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Contour> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Contour> UpdateAsync(Entities.Contour u)
        {
            throw new NotImplementedException();
        }
    }
}
