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

namespace HRMS.Logic.Service
{
    public class LoginUsersService : ILoginUsers
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public LoginUsersService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteLoginUsers(int id)
        {
            try
            {

                var record = _hRMSContext.LoginUsers.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.LoginUsers.Remove(record);
                    _hRMSContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Record Not Found");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public tblhrLoginUsersVM GetLoginUsersByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblhrLoginUsersVM>(_hRMSContext.LoginUsers.Where(x => x.Id == id).FirstOrDefault());
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

        public List<tblhrLoginUsersVM> LoginUsersList()
       {
            try
            {
                return _mapper.Map<List<tblhrLoginUsersVM>>(_hRMSContext.LoginUsers.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void SaveLoginUsers(tblhrLoginUsersVM obj)
        {
            try
            {
                var department = _mapper.Map<tblhrLoginUsers>(obj);
                _hRMSContext.LoginUsers.Add(department);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdateLoginUsers(tblhrLoginUsersVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrLoginUsers>(obj);
                var record = _hRMSContext.LoginUsers.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.LoginUsers.Update(update);
                    _hRMSContext.SaveChanges();

                }
                else
                {
                    throw new Exception("Reocord Not Update");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
