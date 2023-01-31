using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblhrEmployeeDetails
    {

        void SaveEmpDetails(tblhrEmployeeDetailsVM obj);
        void UpdateEmpDetails(tblhrEmployeeDetailsVM obj);
        void DeleteEmpDetails(int id);
        tblhrEmployeeDetailsVM GetEmpDetailsByid(int id);
        List<tblhrEmployeeDetailsVM> EmpDetailsList();


    }
}
