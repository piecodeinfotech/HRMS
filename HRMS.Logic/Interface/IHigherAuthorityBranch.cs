using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IHigherAuthorityBranch
    {
        void SaveHigherAuthorityBranch(HigherAuthorityBranchVM obj);
        void UpdateHighAuthorityBranch(HigherAuthorityBranchVM obj);
        void DeleteHighAuthorityBranch(int id);
        HigherAuthorityBranchVM GetHighAuthorityBranchByid(int id);
        List<HigherAuthorityBranchVM> HigherAuthorityBranchList();
    }
}
