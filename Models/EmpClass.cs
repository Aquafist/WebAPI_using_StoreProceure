using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiStoreProcedure.Models
{
    public class EmpClass
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentID { get; set; }
        public string EmailID { get; set; }
        public DateTime DOJ { get; set; }
    }
}