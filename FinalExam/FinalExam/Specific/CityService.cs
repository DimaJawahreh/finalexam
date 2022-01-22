using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExam.Context;
using FinalExam.data;

namespace FinalExam.Specific
{
    public class CityService: ICityService
    {
        FinalContext context;
        public CityService(FinalContext finalContext)
        {
            context = finalContext;
        }
         public List<city> GetCities()
        {
            List<city> cities = context.city.ToList();
            return cities;
        }

    }
}
