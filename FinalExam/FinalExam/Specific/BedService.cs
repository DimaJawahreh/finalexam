using FinalExam.Context;
using FinalExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Specific
{
    public class BedService : IBedService
    {
        FinalContext context;
        public BedService(FinalContext finalContext)
        {
            context = finalContext;
        }
        public List<Bed> GetBeds()
        {
            List<Bed> beds = context.Bed.ToList();
            return beds;
        }
    }
}
