﻿using Microsoft.AspNetCore.Mvc;
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
    public class GetPathFromUsaToController : ControllerBase
    {
        private readonly IShortestPathFinderOutput pathFinderOutput;
        public GetPathFromUsaToController(IShortestPathFinderOutput shortestPathFinderOutput)
        {
            pathFinderOutput = shortestPathFinderOutput;
        }

        // GET api/<GetPathFromUsaTo>/
        [HttpGet]
        public int Get()
        {
            return 10;
        }

        // GET api/<GetPathFromUsaTo>/BLZ
        [HttpGet("{code}")]
        public object Get(string code)
        {
            return new
            {
                destination = code,
                list = pathFinderOutput.GetVisitedVerticesList("USA", code).ToArray()
            };
        }
    }
}
