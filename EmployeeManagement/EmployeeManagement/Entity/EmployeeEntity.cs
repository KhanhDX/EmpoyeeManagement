using System;
using EmployeeManagement.Common;

namespace EmployeeManagement.Entity
{
    public class EmployeeEntity
    {
        public String EmployeeNumber { get; set; }
        public String EmployeeFirstName { get; set; }
        public String EmployeeLastName { get; set; }
        public String Address { get; set; }
        public String IDCard { get; set; }
        public DateTime DOB { get; set; }
        public SexValue Sex { get; set; }
        public JobRankValue JobRankType { get; set; }
        public int JobRankLevel { get; set; }
        public int SalaryLevel { get; set; }
        public int SalarySubLevel { get; set; }
    }
}
