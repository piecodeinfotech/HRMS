using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IBranches
    {
        void SaveBranch(BranchesVM obj);
        void UpdateBranch(BranchesVM obj);
        void DeleteBranch(int id);
        BranchesVM GetBrancheByid(int id);
       List<BranchesVM> Branchlist();

    }
}
