using LifeGaurd.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Interfaces
{
    public interface IContour
    {
        Task<DbSet<Contour>> GetAllAsync();
        Task<Contour> GetByIdAsync(int Id);

        Task<Contour> AddAsync(int ContourId, int W, int X, int Y, int Z);
        Task<Contour> UpdateAsync(Contour u);
        Task DeleteAsync(int id);
    }
}
