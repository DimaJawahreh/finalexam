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
    public class CountryController : ControllerBase
    {
        ICountryService countryservice;
        public CountryController(ICountryService _countryService)
        {
            countryservice = _countryService;
        }
        [HttpGet]
        [Route("countries")]
        public List<country> GetCountries()
        {
            List<country> countries = countryservice.GetCountries();
            return countries;
        }
    }
}
