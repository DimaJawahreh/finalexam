using FinalExam.Context;
using FinalExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Specific
{
    public class DoctorService: IDoctorService
    {
        FinalContext context;
        public DoctorService(FinalContext finalContext)
        {
            context = finalContext;
        }
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = context.Doctor.ToList();
            return doctors;
        }
    }
}
