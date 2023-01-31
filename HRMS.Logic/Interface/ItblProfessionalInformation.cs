using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblProfessionalInformation
    {
        void SaveProfInfo(tblProfessionalInformationVM obj);
        void UpdateProfInfo(tblProfessionalInformationVM obj);
        void DeleteProfInfo(int id);
        tblProfessionalInformationVM GetProfInfoByid(int id);
        List<tblProfessionalInformationVM> ProfInfoList();
    }
}
