using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    public class tblhrLoginUsersVM
    {
        public int Id { get; set; }
        public int? Login_User_System_Code { get; set; }
        public string? Login_Id { get; set; }
        public string? Salt_Value { get; set; }
        public string? Hash_Password { get; set; }
        public bool? Is_Password_Reset_Required { get; set; }
        public DateTime? Password_ChangedOn_Date { get; set; }
        public int? Wrong_Password_Attempt { get; set; }
        public DateTime? Account_LockedOn_Date { get; set; }
        public DateTime? Login_Valid_Upto_Date { get; set; }
        public string? Reference_Table_Name { get; set; }
        public int? Reference_Primary_Id { get; set; }
        public int? Login_User_Type_Id { get; set; }
        public int? Status_Id { get; set; }
        public string? Remarks { get; set; }
        public string? Action_Remarks { get; set; }
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



