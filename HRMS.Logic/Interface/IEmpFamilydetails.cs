using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IEmpFamilydetails
    {
        void SaveEmpFamilyDetails(tblhrEmployeeFamilyDetailsVM obj);
        void UpdateEmpFamilyDetails(tblhrEmployeeFamilyDetailsVM obj);
        void DeleteEmpFamilyDetails(int id);
        tblhrEmployeeFamilyDetailsVM GetEmpFamilyDetailsByid(int id);
        List<tblhrEmployeeFamilyDetailsVM> EmpFamilyDetailsList();
    }
}
