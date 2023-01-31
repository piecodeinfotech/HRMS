using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    public class tblOtherInformationVM
    {
        public int Id { get; set; }
        public string? Bank_Name { get; set; }
        public string? Branch_Name { get; set; }
        public string? Account_No { get; set; }
        public string? IFSC_Code { get; set; }
        public bool? Status { get; set; }
        public string? Other_Details { get; set; }
        public string? Card_No { get; set; }
        public string? CarProxy_Nod_No { get; set; }
        public int? User_Type { get; set; }
        public string? Signature { get; set; }
        public string? Picture { get; set; }
        public int? Employee_Id { get; set; }
        public int? Status_Id { get; set; }
        public string? Remarks { get; set; }
        public string? Action_Remarks { get; set; }
        public string? User_Id { get; set; }
        public string? User_Data { get; set; }
        public DateTime? CreatedOn_Date { get; set; }
        public int? CreatedBy_Login_User_Id { get; set; }
        public int? CreatedBy_Login_Session_Id { get; set; }
        public string? CreatedFrom_Page { get; set; }
        public int? CreatedFrom_Sub_Menu_Id { get; set; }
        public string? CreatedFrom_API_Name { get; set; }
        public DateTime? UpdatedOn_Date { get; set; }
        public int? UpdatedBy_Login_User_Id { get; set; }
        public int? UpdatedBy_Login_Session_Id { get; set; }
        public string? UpdatedFrom_Page { get; set; }

        public int? UpdatedFrom_Sub_Menu_Id { get; set; }
        public string? UpdatedFrom_API_Name { get; set; }

    }
}



