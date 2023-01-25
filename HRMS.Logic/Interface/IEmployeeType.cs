using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IEmployeeType
    {
        void SaveEmployeeType(EmployeeTypeVM obj);
        void UpdateEmployeeType(EmployeeTypeVM obj);
        void DeleteEmployeeType(int id);
        EmployeeTypeVM GetEmployeeTypeByid(int id);
        List<EmployeeTypeVM> EmployeeTypeList();
    }
}
