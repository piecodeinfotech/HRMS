using AutoMapper;
using HRMS.Logic.Database.Entities;
using HRMS.Model;

namespace HRMS.Helpers
{
    public class AutoMapperProfile:Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<BloodGroupVM, BloodGroup>().ReverseMap(); //reverse so the both direction
        }
    }
}
