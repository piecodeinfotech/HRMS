using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IEmployeeEducations
    {

        void SaveEmpEducations(tblhrEmployeeEducationsVM obj);
        void UpdateEmpEducations(tblhrEmployeeEducationsVM obj);
        void DeleteEmpEducations(int id);
        tblhrEmployeeEducationsVM GetEmpEducationsByid(int id);
        List<tblhrEmployeeEducationsVM> EmpEducationsList();
    }
}
