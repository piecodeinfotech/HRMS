using AutoMapper;
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
            CreateMap<CorresspondanceContInfoVM, CorresspondanceContInfo>().ReverseMap();
            CreateMap<EducQualifiAttachVM, EduQualifiAttachService>().ReverseMap();

        }
    }
}
    