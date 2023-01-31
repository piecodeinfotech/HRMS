using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IIdentityProofAttach
    {
        void SaveIdentityProofAttach(tblIdentityProofAttachVM obj);
        void UpdateIdentityProofAttach(tblIdentityProofAttachVM obj);
        void DeleteIdentityProofAttach(int id);
        tblIdentityProofAttachVM GetIdentityProofAttachByid(int id);
        List<tblIdentityProofAttachVM> IdentityProofAttachList();
    }
}
