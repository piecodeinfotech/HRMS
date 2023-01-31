using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblEduQualifiAttach
    {
        void SaveEduQualifiAttach(tblEducQualifiAttachVM obj);
        void UpdateEduQualifiAttach(tblEducQualifiAttachVM obj);
        void DeleteEduQualifiAttach(int id);
        tblEducQualifiAttachVM GetEduQualifiAttachByid(int id);
        List<tblEducQualifiAttachVM> EduQualifiAttachList();
    }
}
