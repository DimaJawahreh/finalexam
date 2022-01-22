using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.data
{
    [Table("Deprtments")]
    public class Department
    {
        public int id { set; get; }
        public string name { set; get; }
        public List<Pateint> pateints { set; get; }
    }
}
