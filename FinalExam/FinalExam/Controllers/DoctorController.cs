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
    public class DoctorController : ControllerBase
    {
        IDoctorService doctorService;
        public DoctorController(IDoctorService _doctorService)
        {
            doctorService = _doctorService;
        }
        [HttpGet]
        [Route("doctor")]
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctor = doctorService.GetDoctors();
            return doctor;
        }
    }
}
