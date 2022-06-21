using ApbdTest2.Models;
using ApbdTest2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiretrucksController : ControllerBase
    {
        private readonly IDatabaseService _service;
        public FiretrucksController(IDatabaseService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetFireTrucksAsync([FromHeader] int fireTruckId)
        {
            if (!await _service.CheckIfFireTruckExists(fireTruckId))
            {
                return BadRequest("No fire truck with given id exists");
            }
            var fireTrucks = await _service.GetFireTrucksAsync(fireTruckId);

            return Ok(fireTrucks);
        }
    }
}
