using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IThirdParty
    {
        void SaveThirdParty(ThirdPartyVM obj);
        void UpdateThirdParty(ThirdPartyVM obj);
        void DeleteThirdParty(int id);
        ThirdPartyVM GetThirdPartyByid(int id);
        List<ThirdPartyVM> ThirdPartyList();
    }
}
