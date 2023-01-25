using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ICast
    {
        void CastCreate(CastVM obj);
        void CastUpdate(CastVM obj);
        void CastDelete(int id);
        CastVM CastById(int CastId);
        List<CastVM> GetCast();

    }
}
