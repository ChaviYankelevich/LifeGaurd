using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGaurd.Repositories.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string IPAdress { get; set; }
        public Pool Pool { get; set; }
        string UserName,string Phone,string Adress,string Email,string IPAdress, Pool Pool
    }
}
