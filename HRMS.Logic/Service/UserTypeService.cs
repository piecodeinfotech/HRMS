using AutoMapper;
using HRMS.Logic.Database;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HRMS.Logic.Service
{
    public class UserTypeService : IUserType
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public UserTypeService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;
                _mapper = mapper;
        }
        public void DeleteUserType(int id)
        {
            try
            {

                var record = _hRMSContext.UserType.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.UserType.Remove(record);
                    _hRMSContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Record NOt Found");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public UserTypeVM GetUserTypeByid(int id)
        {
            try
            {
                var data = _mapper.Map<UserTypeVM>(_hRMSContext.UserType.Where(x => x.Id == id).FirstOrDefault());

                if (data == null)
                {
                    throw new Exception("Invalid Id");
                }
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveUserType(UserTypeVM obj)
        {
            try
            {
                var userType = _mapper.Map<UserType>(obj);
                _hRMSContext.UserType.Add(userType);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

     

        public List<UserTypeVM> UserTypeList()
        {
            return _mapper.Map<List<UserTypeVM>>(_hRMSContext.UserType.ToList());

        }
        public void UpdateUserType(UserTypeVM obj)
        {
            try
            {
                var update = _mapper.Map<UserType>(obj);
                var record = _hRMSContext.UserType.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.UserType.Update(update);
                    _hRMSContext.SaveChanges();

                }
                else
                {
                    throw new Exception("Reocord Not Update");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

