

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
        void SaveCorreContInfo(tblCorresspondanceContInfoVM obj);
        void UpdateCorreContInfo(tblCorresspondanceContInfoVM obj);
        void DeleteCorreContInfo(int id);
        tblCorresspondanceContInfoVM GetCorreContInfoByid(int id);
        List<tblCorresspondanceContInfoVM> CorreContInfoList();
    }
}
