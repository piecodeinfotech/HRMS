using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IHigherAuthority
    {
        void SaveHigherAuthority(HigherAuthorityVM obj);
        void UpdateHigherAuthority(HigherAuthorityVM obj);
        void DeleteHigherAuthority(int id);
        HigherAuthorityVM GetHigherAuthorityByid(int id);
        List<HigherAuthorityVM> HigherAuthorityList();
    }
}
