using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItbluserType
    {
        void SavetblUserType(tblUserTypeVM obj);
        void UpdatetblUserType(tblUserTypeVM obj);
        void DeletetblUserType(int id);
        tblUserTypeVM GettblUserTypeByid(int id);
        List<tblUserTypeVM> tblUserTypeList();
    }
}
