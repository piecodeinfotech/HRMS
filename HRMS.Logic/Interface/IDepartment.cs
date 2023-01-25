using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IDepartment
    {
        void SaveDeapartment(DepartmentVM obj);
        void UpdateDeapartment(DepartmentVM obj);
        void DeleteDeapartment(int id);
        DepartmentVM GetDeapartmentByid(int id);
        List<DepartmentVM> DepartmentList();
    }
}
