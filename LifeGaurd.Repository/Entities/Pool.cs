using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Entities
{
    public class Pool
    {
        public int PoolId { get; set; }
        public User User { get; set; }
        public int WaterContour { get; set; }

    }
}
