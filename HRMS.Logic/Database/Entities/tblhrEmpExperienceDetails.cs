using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HRMS.Logic.Database.Entities
{
    [Table("tbl_hr_Employee_Experience_Details")]
    public class tblhrEmpExperienceDetails
    {
        [Key]
        public int Id { get; set; }
        public int? Employee_Id { get; set; }
        public string? Employer_Name { get; set; }
        public string? Employer_Address { get; set; }
        public int? Employer_StateId { get; set; }
        public string? Employer_Zip_Code { get; set; }
        public string? Employer_City { get; set; }
        public string? Employer_Contact_Preson { get; set; }
        public string? Employer_Contact_Designation { get; set; }
        public string? Employer_Contact_Mobile { get; set; }
        public string? Employer_Contact_EmailId { get; set; }
        public decimal? Last_Drawn_Salary { get; set; }
        public DateTime? Employer_DOJ { get; set; }
        public DateTime? Employer_DOL { get; set; }
        public string? Reason_Of_Leaving { get; set; }
        public string? Remarks { get; set; }
        public string? AttachmentType_Path { get; set; }
        public string? Attachment_Type { get; set; }
    }
}
