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
        public DbSet<CorresspondanceContInfo> CorresspondanceContInfo { get; set; }
        public DbSet<EducQualifiAttach> EduQualifiAttach { get; set; }
        public DbSet<EmployeeMaster> EmployeeMaster { get; set; }

    }
}
