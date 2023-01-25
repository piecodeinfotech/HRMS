using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database.Entities
{
    [Table("tbl_Educational_Qualification_Attachements")]
    public class EducQualifiAttach
    {
        [Key]
        public int Id { get; set; }
        public int Educational_Qualification_Id { get; set; }
        public int EmployeeId { get; set; }
        public string? CourseName { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentUrl { get; set; }
    }
}
