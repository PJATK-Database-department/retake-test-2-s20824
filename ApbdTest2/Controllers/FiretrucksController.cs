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
    [Route("api/firetrucks")]
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

        [HttpPost]
        public async Task<IActionResult> UpdateActionendDate(int actionId, DateTime endTime)
        {
            if (await _service.checkIfActionExists(actionId))
            {
                return BadRequest("No action with given id exists");
            }
            if (await _service.checkIfEndTimeValid(endTime))
            {
                return BadRequest("End time cannot be biiger than the start time");
            }
            if (await _service.checkIfEndTimeExists(endTime))
            {
                return BadRequest("End time is already set");
            }
            return StatusCode(201, actionId);
        }
    }
}
