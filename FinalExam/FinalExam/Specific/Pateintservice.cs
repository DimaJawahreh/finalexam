using FinalExam.Context;
using FinalExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Specific
{
    public class Pateintservice: IPateintservice
    {
        FinalContext context;
        public Pateintservice(FinalContext finalContext)
        {
            context = finalContext;
        }
        public void insert(Pateint pateint)
        {
            context.Pateint.Add(pateint);
            context.SaveChanges();
        }
    }
}
