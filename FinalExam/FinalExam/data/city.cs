using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.data
{
    [Table("cities")]
    public class city
    {
        public int id { set; get; }
        public string name { set; get; }
        [ForeignKey("country")]
        public int country_id { set; get; }
        public country country { set; get; }
        public List<Pateint> pateints { set; get; }
    }
}
