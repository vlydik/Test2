using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Entities
{
    public class BreedType
    {
        public int IdBreedType { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
