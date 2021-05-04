using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPathFromUsaTo : ControllerBase
    {
        private readonly IShortestPathFinderOutput pathFinderOutput;
        public GetPathFromUsaTo(IShortestPathFinderOutput shortestPathFinderOutput)
        {
            pathFinderOutput = shortestPathFinderOutput;
        }

        // GET api/<GetPathFromUsaTo>/BLZ
        [HttpGet("{code}")]
        public string[] Get(string code)
        {
            return pathFinderOutput.GetVisitedVerticesList("USA", code).ToArray();
        }
    }
}
