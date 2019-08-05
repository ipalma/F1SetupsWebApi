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
    public class F1DriversController : ControllerBase
    {
        private readonly F1DriversDAO dao;
        public F1DriversController(F1DriversDAO dao)
        {
            this.dao = dao;
        }


        [HttpGet]
        public List<F1Driver> GetDrivers()
        {
            return dao.GetDrivers();
        }

        [HttpGet("{id}", Name ="GetDriverById")]
        public F1Driver GetDriverById(int id)
        {
            return dao.GetDriver(id);
        }

    }
}