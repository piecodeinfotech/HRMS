using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IRegions
    {
        void SaveRegion(RegionsVM obj);
        void UpdateRegion(RegionsVM obj);
        void DeleteRegion(int id);
        RegionsVM GetRegionByid(int id);
        List<RegionsVM> RegionList();
    }
}
