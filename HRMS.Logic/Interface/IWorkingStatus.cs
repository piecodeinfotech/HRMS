using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IWorkingStatus
    {
        void SaveWorkingStatus(WorkingStatusVM obj);
        void UpdateWorkingStatus(WorkingStatusVM obj);
        void DeleteWorkingStatus(int id);
        WorkingStatusVM GetWorkingStatusByid(int id);
        List<WorkingStatusVM> WorkingStatusList();


    }
}
