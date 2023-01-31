using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface Itbl_HighestQualification
    {
        void Save_tblHighQualifi(tbl_HighestQualificationVM obj);
        void Update_tblHighQualifi(tbl_HighestQualificationVM obj);
        void Delete_tblHighQualifi(int id);
        tbl_HighestQualificationVM Get_tblHighQualifiById(int CastId);
        List<tbl_HighestQualificationVM> Get_tblHighQualifiList();
    }
}
