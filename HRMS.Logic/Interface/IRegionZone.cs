using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IRegionZone
    {
        void SaveRegionZone(RegionZoneVM obj);
        void UpdateRegionZone(RegionZoneVM obj);
        void DeleteRegionZone(int id);
        RegionZoneVM GetRegionZoneByid(int id);
        List<RegionZoneVM> RegionZoneList();
    }
}
