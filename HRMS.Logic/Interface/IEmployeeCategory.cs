using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IEmployeeCategory
    {
        void SaveEmployeeCategory(EmployeeCategoryVM obj);
        void UpdateEmployeeCategory(EmployeeCategoryVM obj);
        void DeleteEmployeeCategory(int id);
        EmployeeCategoryVM GetEmployeeCategoryByid(int id);
        List<EmployeeCategoryVM> EmployeeCategoryList();
    }
}
