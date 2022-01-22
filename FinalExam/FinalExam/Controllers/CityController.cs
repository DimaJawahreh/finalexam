using FinalExam.data;
using FinalExam.Specific;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        ICityService CityService;
        public CityController(ICityService city)
        {
            CityService = city;
        }
        [HttpGet]
        [Route("GetCities")]
         public List<city> GetCities()
        {
            List<city> cities = CityService.GetCities();
            return cities;
        }
    }
}
