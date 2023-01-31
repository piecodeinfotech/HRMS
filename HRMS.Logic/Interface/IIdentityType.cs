using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IIdentityType
    {
        void SaveIdentityType(tblIdentityTypeVM obj);
        void UpdateIdentityType(tblIdentityTypeVM obj);
        void DeleteIdentityType(int id);
        tblIdentityTypeVM GetIdentityTypeByid(int id);
        List<tblIdentityTypeVM> IdentityTypeList();
    }
}
