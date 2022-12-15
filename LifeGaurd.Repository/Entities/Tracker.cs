using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Entities
{
    public enum EStatus { inDanger,inWarning,Safe}
    public class Tracker
    {
        public int TrackerId { get; set; }
        public Pool Pool { get; set; }
        public Contour TrackerCourter { get; set; }
        public EStatus Status { get; set; }
    }
}
