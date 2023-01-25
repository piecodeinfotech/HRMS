using HRMS.Logic.Database.Entities;
using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IProfessionalInformation
    {
        void SaveProInfo(ProfessionalInformationVM obj);
        void UpdateProInfo(ProfessionalInformationVM obj);
        void DeleteProInfo(int id);
        ProfessionalInformationVM GetProInfoByid(int id);
        List<ProfessionalInformationVM> ProInfoList();
    }
}
