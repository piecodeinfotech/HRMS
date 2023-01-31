using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IPermanentContInfo
    {
        void SavePermanentContInfo(tblPermanentContInfoVM obj);
        void UpdatePermanentContInfo(tblPermanentContInfoVM obj);
        void DeletePermanentContInfo(int id);
        tblPermanentContInfoVM GetPermanentContInfoByid(int id);
        List<tblPermanentContInfoVM> PermanentContInfoList();
    }
}
