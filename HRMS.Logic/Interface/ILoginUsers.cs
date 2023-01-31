using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ILoginUsers
    {
        void SaveLoginUsers(tblhrLoginUsersVM obj);
        void UpdateLoginUsers(tblhrLoginUsersVM obj);
        void DeleteLoginUsers(int id);
        tblhrLoginUsersVM GetLoginUsersByid(int id);
        List<tblhrLoginUsersVM> LoginUsersList();
    }
}
