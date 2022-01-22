using FinalExam.Context;
using FinalExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Specific
{
    public class CountryService: ICountryService
    {
        FinalContext context;
        public CountryService(FinalContext finalContext)
        {
            context = finalContext;
        }
        public List<country> GetCountries()
        {
            List<country> countries = context.country.ToList();
            return countries;
        }
    }
}
