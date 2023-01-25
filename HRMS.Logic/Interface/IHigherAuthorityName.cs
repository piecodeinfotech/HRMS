using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IHigherAuthorityName
    {
        void SaveHighAuthName(HigherAuthorityNameVM obj);
        void UpdateHighAuthName(HigherAuthorityNameVM obj);
        void DeleteHighAuthName(int id);
        HigherAuthorityNameVM GetHighAuthNameByid(int id);
        List<HigherAuthorityNameVM> HighAuthNameList();

    }
}
