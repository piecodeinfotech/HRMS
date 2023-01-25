using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IThirdPartyType
    {
        void SaveThirdPartyType(ThirdPartyTypeVM obj);
        void UpdateThirdPartyType(ThirdPartyTypeVM obj);
        void DeleteThirdPartyType(int id);
        ThirdPartyTypeVM GetThirdPartyTypeByid(int id);
        List<ThirdPartyTypeVM> ThirdPartyTypeList();
    }
}
