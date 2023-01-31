using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database.Entities
{

    [Table("tbl_hr_Employee_Educations")]
    public class tblhrEmployeeEducations
    {
        [Key]

        public int Id { get; set; }
        public int? Employee_Id { get; set; }
        public int? Enum_Id { get; set; }
        public int? Emp_Year_OF_Passing { get; set; }
        public string? Emp_Organization { get; set; }
        public string? Emp_Board_Council_University { get; set; }
        public string? Emp_Qualification_Percent { get; set; }
        public string? Emp_Qualification_Percentile { get; set; }
        public string? Remarks { get; set; }
        public string? AttachmentType_Path { get; set; }
        public string? Attachment_Type { get; set; }
    }
}
