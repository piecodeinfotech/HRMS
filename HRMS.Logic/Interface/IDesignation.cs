using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IDesignation
    {
        void SaveDesignation(DesignationVM obj);
        void UpdateDesignation(DesignationVM obj);
        void DeleteDesignation(int id);
        DesignationVM GetDesignationByid(int id);
        List<DesignationVM> DesignationList();
    }
}
