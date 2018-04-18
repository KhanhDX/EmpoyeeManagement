using System;
using System.Data;
using EmployeeManagement.Common;

namespace EmployeeManagement.DAL
{
    class EmployeeDAL
    {
        public class EmployeeDAL : ICommonDAL
        {
            public long Add(ICommonEntity employee)
            {
                throw new NotImplementedException();
            }


            public bool Delete(int ID)
            {
                throw new NotImplementedException();
            }


            public bool Edit(ICommonEntity employee, int ID)
            {
                throw new NotImplementedException();
            }

            public static DataTable LoadAll()
            {
                DataTable data = new DataTable();
                return data;
            }
        }
    }
}
