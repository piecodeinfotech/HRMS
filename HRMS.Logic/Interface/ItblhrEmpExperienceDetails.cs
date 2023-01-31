using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblhrEmpExperienceDetails
    {
        void SaveEmpExpeDetails(tblhrEmpExperienceDetailsVM obj);
        void UpdateEmpExpeDetails(tblhrEmpExperienceDetailsVM obj);
        void DeleteEmpExpeDetails(int id);
        tblhrEmpExperienceDetailsVM EmpExpeDetailsById(int id);
        List<tblhrEmpExperienceDetailsVM> GetEmpExpeDetails();
    }
}
