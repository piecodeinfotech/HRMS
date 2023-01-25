using HRMS.Logic.Database.Entities;
using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IEmployeeMaster
    {
        void SaveEmployeeMaster(EmployeeMasterVM obj);
        void UpdateEmployeeMaster(EmployeeMasterVM obj);
        void DeleteEmployeeMaster(int id);
        EmployeeMasterVM GetEmployeeMasterByid(int id);
        List<EmployeeMasterVM> EmployeeMasterList();
    }
}
