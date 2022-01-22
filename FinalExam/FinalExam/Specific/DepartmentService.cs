using FinalExam.Context;
using FinalExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Specific
{
    public class DepartmentService : IDepartmentService
    {
        FinalContext context;
        public DepartmentService(FinalContext finalContext)
        {
            context = finalContext;
        }
        public List<Department> GetDepartments()
        {
            List<Department> departments = context.Department.ToList();
            return departments;
        }
    }
}
