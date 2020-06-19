using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.DTOs
{
    public class PetsRequest
    {
        [Required]
        public int IdVolunteer { get; set; }
        public int Year { get; set; }
    }
}
