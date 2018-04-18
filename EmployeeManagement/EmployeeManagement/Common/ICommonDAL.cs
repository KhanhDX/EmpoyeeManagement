using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.employees;

namespace EmployeeManagement.Common
{
    public interface ICommonDAL
    {
        long Add(ICommonEntity commonEntity);
        bool Edit(ICommonEntity commonEntity, int ID);
        bool Delete(int ID);
    }
}
