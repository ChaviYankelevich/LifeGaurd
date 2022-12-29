using LifeGaurd.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Interfaces
{
    public interface IcontourRepository
    {
        Task<DbSet<Contour>> GetAllAsync();
        Task<Contour> GetByIdAsync(int Id);

        Task<Contour> AddAsync(int ContourId, int W, int X, int Y, int Z);

        Task<Contour> UpdateAsync(Contour c);
        Task DeleteAsync(int id);
    }
}
