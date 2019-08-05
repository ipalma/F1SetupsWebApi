using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace F1SetupsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class F1RaceCircuitsController : ControllerBase
    {
        F1RaceCircuitsDAO dao;

        public F1RaceCircuitsController(F1RaceCircuitsDAO dao)
        {
            this.dao = dao;
        }
        [HttpGet]
        public List<F1RaceCircuit> Get()
        {
            return dao.Get();
        }

        [HttpGet("{id}", Name = "GetRaceCircuit")]
        public F1RaceCircuit GetRaceCircuit(int id)
        {
            return dao.Get(id);
        }

    }
}