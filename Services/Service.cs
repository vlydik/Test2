using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.DTOs;
using Test2.Entities;

namespace Test2.Services
{
    public class Service : IService
    {
       
        private readonly Context _context;

        public Service(Context context)
        {
            context = _context;
        }


        public void AssignPetToVolunteer(AssignRequest request)
        {
          
            var res = _context.Volunteer_Pet.Where(p => p.IdVolunteer == request.IdVolunteer
           && ((p.DateAccepted.Year > request.Year) || (request.Year == 0))
            ).Join(_context.Pet,
                 p => p.IdPet,
                 pet => pet.IdPet,
                 (v_p, pet) => new PetsResponse
                 {
                     IdPet = pet.IdPet,
                     IdBreedType = pet.IdBreedType,
                     IsMale = pet.IsMale,
                     DateAdopted = pet.DateAdopted,
                     Name = pet.Name,
                     ApproximateDateOfBirth = pet.ApproximateDateOfBirth,
                     DateRegistered = pet.DateRegistred,
                     
                 }).ToList();

            return new PetsResponse() { Pets = res };
        }
    }

        public void GetPets(Context context)
        {
            throw new NotImplementedException();
        }

        public void InitContext(Context _context)
        {
            context = _context;
        }

    }
}
