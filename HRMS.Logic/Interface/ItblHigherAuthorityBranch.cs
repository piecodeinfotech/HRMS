using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblHigherAuthorityBranch
    {
        void SavetblHigherAuthBranch(tbl_HigherAuthorityBranchVM obj);
        void UpdatetblHigherAuthBranch(tbl_HigherAuthorityBranchVM obj);
        void DeletetblHigherAuthBranch(int id);
        tbl_HigherAuthorityBranchVM GettblHigherAuthBranchByid(int id);
        List<tbl_HigherAuthorityBranchVM> tblHigherAuthBranchList();
    }
}
