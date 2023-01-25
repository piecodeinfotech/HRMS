using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IUserType
    {
        void SaveUserType(UserTypeVM obj);
        void UpdateUserType(UserTypeVM obj);
        void DeleteUserType(int id);
        UserTypeVM GetUserTypeByid(int id);
        List<UserTypeVM> UserTypeList();

    }
}
