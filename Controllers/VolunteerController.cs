using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test2.Entities;
using Test2.Services;

namespace Test2.Controllers
{
    [ApiController]
    public class VolunteerController : ControllerBase
    {

        private readonly IService _dbService;

        public VolunteerController(IService service, Context context)
        {
            _dbService = service;
            _dbService.InitContext(context);
        }
        [HttpGet("volunteers/{id}/pets")]
        public IActionResult GetVolunteer(int idVolunteer)
        {
            var output = _dbService.GetVolunteer(idVolunteer);
            if (output is null) return BadRequest();
            return Ok(output);
        
        }
        [HttpPost("volunteers/{id}/pets")]
        //public IActionResult AssignPet()
    }
}