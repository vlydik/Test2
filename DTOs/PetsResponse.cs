using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.DTOs
{
    public class PetsResponse
    {
        public struct Volunteers_Data
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public DateTime StartingDate { get; set; }
        }
        public int IdPet { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime ApproximateDateOfBirth { get; set; }
        public DateTime DateAdopted { get; set; }
        public List<Volunteers_Data> Volunteers { get; set; }
            }
}
