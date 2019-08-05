using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Teams;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace F1SetupsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class F1TeamsController : ControllerBase
    {
        F1TeamsDAO dao;
        public F1TeamsController(F1TeamsDAO dao)
        {
            this.dao = dao;
        }

        [HttpGet]
        public List<F1Team> Get()
        {
            return this.dao.GetF1Teams();
        }

        [HttpGet("{id}",Name = "Get")]
        public F1Team Get(int id)
        {
            return dao.GetF1Team(id);
        }


    }
}