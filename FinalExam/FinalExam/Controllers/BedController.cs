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
    public class BedController : ControllerBase
    {
        IBedService bedService;

        public BedController(IBedService _bedService)
        {
            bedService = _bedService;
        }
        [HttpGet]
        [Route("GetBeds")]
        public List<Bed> GetBeds()
        {
            List<Bed> beds = bedService.GetBeds();
            return beds;
        } 
    }
}
