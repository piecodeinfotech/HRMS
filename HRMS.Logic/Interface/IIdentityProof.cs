using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IIdentityProof
    {
        void SaveIdentityProof(tblIdentityProofVM obj);
        void UpdateIdentityProof(tblIdentityProofVM obj);
        void DeleteIdentityProof(int id);
        tblIdentityProofVM GetIdentityProofByid(int id);
        List<tblIdentityProofVM> IdentityProofList();
    }
}
