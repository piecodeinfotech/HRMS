using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IEduQualifiAttach
    {
        void SaveEduQualifiAttach(EducQualifiAttachVM obj);
        void UpdateEduQualifiAttach(EducQualifiAttachVM obj);
        void DeleteEduQualifiAttach(int id);
        EducQualifiAttachVM GetEduQualifiAttachByid(int id);
        List<EducQualifiAttachVM> EduQualifiAttachList();
    }
}
