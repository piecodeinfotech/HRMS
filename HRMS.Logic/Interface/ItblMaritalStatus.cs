using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblMaritalStatus
    {
        void SaveMaritalStatus(tblMaritalStatusVM obj);
        void UpdateMaritalStatus(tblMaritalStatusVM obj);
        void DeleteMaritalStatus(int id);
        tblMaritalStatusVM GetMaritalStatusByid(int id);
        List<tblMaritalStatusVM> MaritalStatusList();
    }
}
