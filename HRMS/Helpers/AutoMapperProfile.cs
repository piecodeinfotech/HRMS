using AutoMapper;
using HRMS.Controllers;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Service;
using HRMS.Model;

namespace HRMS.Helpers
{
    public class AutoMapperProfile:Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<BloodGroupVM, BloodGroup>().ReverseMap(); //reverse so the both direction
            CreateMap<BranchesVM, Branches>().ReverseMap();
            CreateMap<CastVM, Cast>().ReverseMap();
            CreateMap<CompaniesVM, Companies>().ReverseMap();
            CreateMap<CountriesVM, Countries>().ReverseMap();
            CreateMap<DepartmentVM, Department>().ReverseMap();
            CreateMap<DesignationVM, Designation>().ReverseMap();
            CreateMap<DistrictsVM, Districts>().ReverseMap();
            CreateMap<EmployeeCategoryVM, EmployeeCategory>().ReverseMap();
            CreateMap<EmployeeTypeVM, EmployeeType>().ReverseMap();
            CreateMap<HigherAuthorityVM, HigherAuthority>().ReverseMap();
            CreateMap<HigherAuthorityBranchVM, HigherAuthorityBranch>().ReverseMap();
            CreateMap<HigherAuthorityNameVM, HigherAuthorityName>().ReverseMap();
            CreateMap<ProductionsVM, Productions>().ReverseMap();
            CreateMap<RegionZoneVM, RegionZone>().ReverseMap();
            CreateMap<RegionsVM, Region>().ReverseMap();
            CreateMap<RelationshipVM, Relationship>().ReverseMap();
            CreateMap<ProfessionalInformationVM, ProfessionalInformation>().ReverseMap();
            CreateMap<StatesVM, States>().ReverseMap();
            CreateMap<ThirdPartyVM, ThirdParty>().ReverseMap();
            CreateMap<ThirdPartyTypeVM, ThirdPartyType>().ReverseMap();
            CreateMap<UserTypeVM, UserType>().ReverseMap();
            CreateMap<WorkingStatusVM, WorkingStatus>().ReverseMap();

            CreateMap<tblCorresspondanceContInfoVM, tblCorresspondanceContInfo>().ReverseMap();
            CreateMap<tblEducQualifiAttachVM, tblEducQualifiAttach>().ReverseMap();
            CreateMap<tbl_HigherAuthorityBranchVM, tblHigherAuthorityBranch>().ReverseMap();
            CreateMap<EmployeeMasterVM, EmployeeMaster>().ReverseMap();
            CreateMap<tbl_HighestQualificationVM, tbl_HighestQualification>().ReverseMap();
            CreateMap<tblhrEmpActivationotpdetailsVM, tblhrEmpActivationOtpdetails>().ReverseMap();
            CreateMap<tblhrEmployeeDetailsVM, tblhrEmployeeDetails>().ReverseMap();
            CreateMap<tblhrEmployeeEducationDetailsVM, tblhrEmployeeEducationDetails>().ReverseMap();
            CreateMap<tblhrEmployeeEducationsVM, tblhrEmployeeEducations>().ReverseMap();
            CreateMap<tblhrEmpExperienceDetailsVM, tblhrEmpExperienceDetails>().ReverseMap();
            CreateMap<tblhrEmployeeFamilyDetailsVM, tblhrEmployeeFamilyDetails>().ReverseMap();
            CreateMap<tblhrEmpIdproofDetailsVM, tblhrEmpIdProofDetails>().ReverseMap();
            CreateMap<tblhrEmpNomineeDetailsVM, tblhrEmpNomineeDetails>().ReverseMap();
            CreateMap<tblhrLoginUsersVM, tblhrLoginUsers>().ReverseMap();
            CreateMap<tblIdentityProofVM, tblIdentityProof>().ReverseMap();
            CreateMap<tblIdentityProofAttachVM, tblIdentityProofAttach>().ReverseMap();
            CreateMap<tblIdentityTypeVM, tblIdentityType>().ReverseMap();
            CreateMap<tblMaritalStatusVM,tblMaritalStatus>().ReverseMap();
            CreateMap<tblOtherInformationVM,  tblOtherInformation>().ReverseMap();
            CreateMap<tblPermanentContInfoVM, tblPermanentContInfo>().ReverseMap();
            CreateMap<tblProfesInfoAttachVM, tblProfesInfoAttach>().ReverseMap();
            CreateMap<tblProfessionalInformationVM, tblProfessionalInformation>().ReverseMap();
            CreateMap<tblUserTypeVM, tbluserType>().ReverseMap();


        }
    }
}
   