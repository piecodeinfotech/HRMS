using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IEmpNomineeDetails
    {
        void SaveEmpNomineeDetails(tblhrEmpNomineeDetailsVM obj);
        void UpdateEmpNomineeDetails(tblhrEmpNomineeDetailsVM obj);
        void DeleteEmpNomineeDetails(int id);
        tblhrEmpNomineeDetailsVM GetEmpNomineeDetailsByid(int id);
        List<tblhrEmpNomineeDetailsVM> EmpNomineeDetailsList();
    }
}
