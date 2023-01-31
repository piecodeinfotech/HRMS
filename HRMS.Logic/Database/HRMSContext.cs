using HRMS.Logic.Database.Entities;
using HRMS.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Database
{
    public class HRMSContext : DbContext
    {
        public HRMSContext(DbContextOptions<HRMSContext> options) : base(options)
        {

        }
        public DbSet<BloodGroup> BloodGroup { get; set; }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<Districts> Districts { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategory { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<HigherAuthority> HigherAuthority { get; set; }
        public DbSet<HigherAuthorityBranch> HigherAuthorityBranch { get; set; }
        public DbSet<HigherAuthorityName> HigherAuthorityName { get; set; }
        public DbSet<Productions> Productions { get; set; }
        public DbSet<RegionZone> RegionZone { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public DbSet<ProfessionalInformation> ProfessionalInformation { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<ThirdParty> ThirdParty { get; set; }
        public DbSet<ThirdPartyType> ThirdPartyType { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<WorkingStatus> WorkingStatus { get; set; }
        public DbSet<tblCorresspondanceContInfo> CorresspondanceContInfo { get; set; }
        public DbSet<tblEducQualifiAttach> EduQualifiAttach { get; set; }
        public DbSet<EmployeeMaster> EmployeeMaster { get; set; }
        public DbSet<tblHigherAuthorityBranch> tblHigherAuthorityBranch { get; set; }
        public DbSet<tbl_HighestQualification> tblHighestQualification { get; set; }
        public DbSet<tblhrEmpActivationOtpdetails> EmpActivationOtpdetails { get; set; }
        public DbSet<tblhrEmployeeDetails> tblhrEmployeeDetails { get; set; }
        public DbSet<tblhrEmployeeEducationDetails> EmployeeEducationDetails { get; set; }
        public DbSet<tblhrEmployeeEducations> EmployeeEducations { get; set; }
        public DbSet<tblhrEmpExperienceDetails> EmpExperienceDetails { get; set; }
        public DbSet<tblhrEmployeeFamilyDetails> EmpFamilyDetails { get; set; }
        public DbSet<tblhrEmpIdProofDetails> EmpIdProofDetails { get; set; }
        public DbSet<tblhrEmpNomineeDetails> EmpNomineeDetails { get; set; }
        public DbSet<tblhrLoginUsers> LoginUsers { get; set; }
        public DbSet<tblIdentityProof> IdentityProof { get; set; }
        public DbSet<tblIdentityProofAttach> IdentityProofAttach { get; set; }
        public DbSet<tblIdentityType> IdentityType { get; set; }
        public DbSet<tblMaritalStatus> MaritalStatus { get; set; }
        public DbSet<tbluserType> tbluserType { get; set; }
        public DbSet<tblOtherInformation> OtherInformation { get; set; }
        public DbSet<tblPermanentContInfo> PermanentContInfo { get; set; }
        public DbSet<tblProfesInfoAttach> tblProfesInfoAttach { get; set; }
        public DbSet<tblProfessionalInformation> tblProfessionalInformation { get; set; }

    }
}
