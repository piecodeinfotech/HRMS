using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblProfesInfoAttach
    {
        void SaveProfesInfoAttach(tblProfesInfoAttachVM obj);
        void UpdateProfesInfoAttach(tblProfesInfoAttachVM obj);
        void DeleteProfesInfoAttach(int id);
        tblProfesInfoAttachVM GetProfesInfoAttachByid(int id);
        List<tblProfesInfoAttachVM> ProfesInfoAttachList();
    }
}
