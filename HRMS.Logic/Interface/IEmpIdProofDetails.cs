using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IEmpIdProofDetails
    {
        void SaveEmpIdproofDetails(tblhrEmpIdproofDetailsVM obj);
        void UpdateEmpIdproofDetails(tblhrEmpIdproofDetailsVM obj);
        void DeleteEmpIdproofDetails(int id);
        tblhrEmpIdproofDetailsVM GetEmpIdproofDetailsByid(int id);
        List<tblhrEmpIdproofDetailsVM> EmpIdproofDetailsList();
    }
}
