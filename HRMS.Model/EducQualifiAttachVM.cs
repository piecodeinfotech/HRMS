using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Model
{
    public class EducQualifiAttachVM
    {
        public int Id { get; set; }
        public int Educational_Qualification_Id { get; set; }
        public int EmployeeId { get; set; }
        public string? CourseName { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentUrl { get; set; }
    }
}
