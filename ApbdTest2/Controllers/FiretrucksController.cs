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
    }
}
