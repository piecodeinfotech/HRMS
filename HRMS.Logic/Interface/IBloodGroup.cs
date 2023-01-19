using HRMS.Logic.Database.Entities;
using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
   public  interface IBloodGroup
    {
        void BloodCreate(BloodGroupVM obj);
        void BloodUpdate(BloodGroupVM obj);  
        void BloodDelete(int id);
        BloodGroupVM BloodGroupById(int BloodGroupId);
        List<BloodGroupVM> GetBloodGroups();

    }
}
