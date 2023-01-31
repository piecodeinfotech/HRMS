using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database.Entities
{
    [Table("tbl_ProfessionalInformation")]
    public class tblProfessionalInformation
    {
        [Key]
        public int Id { get; set; }
        public string? EmployeerName { get; set; }
        public int? Status_Id { get; set; }
        public string? EmployeerAddress { get; set; }
        public string? Designation { get; set; }
        public string? ContactPerson { get; set; }
        public string? EmailId { get; set; }
        public string? AttachmentType_Path { get; set; }
        public string? Attachment_Type { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public DateTime? DateOfLeaving { get; set; }
        public string? ReasonForLeaving { get; set; }
        public string? LastDrawnSalary { get; set; }
        public string? ContactNo { get; set; }
        public string? Remarks { get; set; }
        public string? Action_Remarks { get; set; }
        public int? Employee_Id { get; set; }
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
