

using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ICorresspondanceContInfo
    {
        void SaveCorreContInfo(CorresspondanceContInfoVM obj);
        void UpdateCorreContInfo(CorresspondanceContInfoVM obj);
        void DeleteCorreContInfo(int id);
        CorresspondanceContInfoVM GetCorreContInfoByid(int id);
        List<CorresspondanceContInfoVM> CorreContInfoList();
    }
}
