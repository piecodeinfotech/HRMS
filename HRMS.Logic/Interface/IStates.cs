using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IStates
    {
            void SaveStates(StatesVM obj);
            void UpdateStates(StatesVM obj);
            void DeleteStates(int id);
            StatesVM GetStatesByid(int id);
            List<StatesVM> StatesList();
    }
}
