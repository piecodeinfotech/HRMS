using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblhrEmployeeEducationDetails
    {
        void SaveEmpEduDetails(tblhrEmployeeEducationDetailsVM obj);
        void UpdateEmpEduDetails(tblhrEmployeeEducationDetailsVM obj);
        void DeleteEmpEduDetails(int id);
        tblhrEmployeeEducationDetailsVM GetEmpEduDetailsByid(int id);
        List<tblhrEmployeeEducationDetailsVM> EmpEduDetailsList();
    }
}
