using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database.Entities
{
    [Table("tbl_hr_Employee_Family_Details")]
    public class tblhrEmployeeFamilyDetails
    {
        [Key]
        public int Id { get; set; }
        public int? Employee_Id { get; set; }
        public string? FamilyDetail_Name { get; set; }
        public int? FamilyDetail_RelationshipId { get; set; }
        public string? FamilyDetail_Mobile { get; set; }
        public string? FamilyDetail_EmailId { get; set; }
        public DateTime? FamilyDetail_DOB { get; set; }
        public string? FamilyDetail_Address { get; set; }
        public string? Identity_Number { get; set; }
        public bool? IsAadharStatus { get; set; }
        public string? AttachmentType_Path { get; set; }
        public string? Attachment_Type { get; set; }
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
