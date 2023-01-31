using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ItblhrEmpActivationOTPdetails
    {
        void SaveEmpActiOtpdetails(tblhrEmpActivationotpdetailsVM obj);
        void UpdateEmpActiOtpdetails(tblhrEmpActivationotpdetailsVM obj);
        void DeleteEmpActiOtpdetails(int id);
        tblhrEmpActivationotpdetailsVM GetEmpActiOtpdetailsByid(int id);
        List<tblhrEmpActivationotpdetailsVM> EmpActiOtpdetailsList();
    }
}
