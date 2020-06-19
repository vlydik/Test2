using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Entities
{
    public class Volunteer
    {

        public int IdVolunteer{ get; set; }
       [ForeignKey("Volunteer")]
       public int IdSuperVisor { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime StartingDate { get; set; }
        

    }
}
