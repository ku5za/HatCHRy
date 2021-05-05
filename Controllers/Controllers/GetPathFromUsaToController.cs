﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.Exceptions;
using UseCases.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Controllers.Controllers
{
    [Route("")]
    [ApiController]
    public class GetPathFromUsaToController : ControllerBase
    {
        private readonly IPathFinderOutput pathFinderOutput;
        public GetPathFromUsaToController(IPathFinderOutput shortestPathFinderOutput)
        {
            pathFinderOutput = shortestPathFinderOutput;
        }

        // GET 
        [HttpGet]
        public decimal Get()
        {
            return (decimal)(new Random().NextDouble());
        }

        // GET /BLZ
        [HttpGet("{code}")]
        public IActionResult Get(string code)
        {
            List<string> visitedCountriesList;
            IActionResult result;

            try
            {
                visitedCountriesList = pathFinderOutput.GetVisitedTerritoriesCodesList("USA", code);
                result = new JsonResult(
                    new
                    {
                        destination = code,
                        list = pathFinderOutput.GetVisitedTerritoriesCodesList("USA", code).ToArray()
                    }
                    );
            }
            catch(NotSupportedCountryCodeException exception)
            {
                result = new NotFoundObjectResult(exception.Message);
            }

            return result;
        }
    }
}
