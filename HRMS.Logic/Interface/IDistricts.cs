using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IDistricts
    {
        void SaveDistricts(DistrictsVM obj);
        void UpdateDistricts(DistrictsVM obj);
        void DeleteDistricts(int id);
        DistrictsVM GetDistrictsByid(int id);
        List<DistrictsVM> DistrictsList();
    }
}
