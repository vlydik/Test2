using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Entities
{
    public class Volunteer_Pet
    {
        [ForeignKey("Volunteer")]
        public int IdVolunteer { get; set; }
        [ForeignKey("Pet")]
        public int IdPet { get; set; }
        public DateTime DateAccepted { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual Volunteer Volunteer { get; set; }

       
    }
}
