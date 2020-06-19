using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test2.DTOs;
using Test2.Entities;
using Test2.Services;

namespace Test2.Controllers
{
    [ApiController]
    [Route("api/volunteers")]
    public class VolunteerController : ControllerBase
    {

        private readonly IService _dbService;

        public VolunteerController(IService service, Context context)
        {
            _dbService = service;
            _dbService.GetPets(context);
        }
        [HttpGet("{id}/pets")]
        public IActionResult GetPets(int id, int year)
        {
            var request = new PetsRequest()
            {
                IdVolunteer = id,
                Year = year
            };
            try
            {
                return Ok(_dbService.GetPets(request));
            }
            catch (Exception ex)
            {
                return BadRequest("Error" );
            }
        }
        [HttpPost("{id}/pets")]
        public IActionResult AssignPet(int id, AssignRequest request)
        {
            request.IdVolunteer = id;

            try
            {
                _dbService.AssignPetToVolunteer(request);
            }
            catch (Exception ex)
            {
                return BadRequest("Error");
            }
            catch (Exception ex)
            {
                return BadRequest("No pet found");
            }
            catch (Exception ex)
            {
                return BadRequest("Volunteer already has a supervisor");
            }
            return Ok();
        }
}