using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.employees;
using System.Data;
using EmployeeManagement.Entity;
using EmployeeManagement.DAL;

namespace EmployeeManagement.BLL
{
    public class employeeBLL
    {
        EmployeeDAL employeeDAL;
        employeeBLL()
        {
            employeeDAL = new EmployeeDAL();
        }
        public void Addemployee(EmployeeEntity employee)
        {
            employeeDAL.Add(employee);
        }

        public void Editemployee(employeeEntity employee, int ID)
        {
            employeeDAL.Edit(employee, ID);
        }

        public void Deleteemployee(int ID)
        {
            employeeDAL.Delete(ID);
        }

        public DataTable LoadAllemployee()
        {
            return employeeDAL.LoadAll();
        }

    }
}
