using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database.Entities
{
    [Table("tbl_hr_Employee_Education_Details")]
    public class tblhrEmployeeEducationDetails
    {
        [Key]
        public int Id { get; set; }
        public int? Employee_Id { get; set; }
        public int? Emp_Year_OF_Passing { get; set; }
        public string? Qualification { get; set; }
        public string? Specialization { get; set; }
        public string? School { get; set; }
        public string? Marks { get; set; }
        public string? Board { get; set; }
        public string? Remarks { get; set; }
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
