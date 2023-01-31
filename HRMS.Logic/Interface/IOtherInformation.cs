using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IOtherInformation
    {
        void SaveOtherInformation(tblOtherInformationVM obj);
        void UpdateOtherInformation(tblOtherInformationVM obj);
        void DeleteOtherInformation(int id);
        tblOtherInformationVM GetOtherInformationByid(int id);
        List<tblOtherInformationVM> OtherInformationList();
    }
}
