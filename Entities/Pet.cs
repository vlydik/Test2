using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Entities
{
    public class Pet
    {
        public int IdPet { get; set; }
        public string Name { get; set; }
        public Boolean IsMale { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime ApproximateDateOfBirth { get; set; }
        public DateTime DateAdopted { get; set; }
        [ForeignKey("BreedType")]
        public int IdBreedType { get; set; }
        public virtual BreedType breedType{get;set; }

        public ICollection<Volunteer_Pet> Pets { get; set; }

    }
}
