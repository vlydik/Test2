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
        Context context;

        public void AssignPetToVolunteer(AssignRequest request)
        {
            throw new NotImplementedException();
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
