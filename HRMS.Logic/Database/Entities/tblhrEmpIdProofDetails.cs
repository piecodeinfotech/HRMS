using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database.Entities
{
    [Table("tbl_hr_Employee_Identityproof_Details")]
    public class tblhrEmpIdProofDetails
    {
        [Key]
        public int Id { get; set; }
        public int? Employee_Id { get; set; }
        public int? Enum_Id { get; set; }
        public DateTime? Emp_DOB { get; set; }
        public string? Identity_Number { get; set; }
        public bool? Is_Verfied { get; set; }
        public DateTime? Date_Valid_From { get; set; }
        public DateTime? Date_Valid_Upto { get; set; }
        public string? AttachmentType_Path { get; set; }
        public string? Attachment_Type { get; set; }
    }
}
