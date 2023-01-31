using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database.Entities
{
    [Table("tbl_hr_Employee_Details")]
    public class tblhrEmployeeDetails
    {
        [Key]
        public int Id { get; set; }
        public int? Employee_Id { get; set; }
        public int? Gender_Id { get; set; }
        public DateTime? Emp_DOB { get; set; }
        public DateTime? Emp_DOJ { get; set; }
        public DateTime? Emp_DOL { get; set; }
        public int? Emp_State_Id { get; set; }
        public string? Emp_Address { get; set; }
        public string? Emp_Address2 { get; set; }
        public string? Emp_Zip_Code { get; set; }
        public string? Emp_City { get; set; }
        public string? Emp_Correspond_Address { get; set; }
        public string? Emp_Correspond_Address2 { get; set; }
        public string? Emp_Correspond_Zip_Code { get; set; }
        public string? Emp_Correspond_City { get; set; }
        public string? Emp_Alternate_Mobile_No { get; set; }
        public string? Emp_Contact_No { get; set; }
        public string? Emp_Alternate_Email_Id { get; set; }
        public int? Enum_Type_Id_Nationality { get; set; }
        public int? Enum_Id_Nationality { get; set; }
        public int? Enum_Type_Id_Religion { get; set; }
        public int? Enum_Id_Religion { get; set; }
        public int? Enum_Type_Id_MaritalStatus { get; set; }
        public int? Enum_Id_MaritalStatus { get; set; }
        public int? Enum_Type_Id_BloodGroup { get; set; }
        public int? Enum_Id_BloodGroup { get; set; }
        public int? Enum_Type_Id_Cast { get; set; }
        public int? Enum_Id_Cast { get; set; }
        public int? Enum_Type_Id_PhysicalDisability { get; set; }
        public int? Enum_Id_PhysicalDisability { get; set; }
        public string? Emp_IdentificationMark { get; set; }
        public int? Enum_Type_Id_HighestQualification { get; set; }
        public int? Enum_Id_HighestQualification { get; set; }
        public int? Enum_Type_Id_Bank { get; set; }

        public int? Enum_Id_Bank { get; set; }
        public string? Emp_Bank_IFSC { get; set; }
        public string? Emp_Bank_AccountNo { get; set; }
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
