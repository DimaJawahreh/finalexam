using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.data
{
    [Table("Patients")]
    public class Pateint
    {
        public string firstname { set; get; }
        public int id  { set; get; } 
        public string lastname { set; get; }
        public string bdate { set; get; }
        //count relation
        [ForeignKey("country")]
        public int country_id { set; get; }
        public country country { set; get; }
        //city relation
        [ForeignKey("city")]
        public int city_id { set; get; }
        public city city { set; get; }
        //department
        [ForeignKey("Department")]
        public int dept_id { set; get; }
        public Department Department { set; get; }

        //doctors
        [ForeignKey("Doctor")]
        public int doctor_id { set; get; }
        public Doctor Doctor { set; get; }

        //room
        [ForeignKey("Room")]
        public int room_id { set; get; }
       public Room Room { set; get; }
       // bed
       [ForeignKey("Bed")]
       public  int bed_id { set; get; }
       public Bed Bed { set; get; }
    }
}

