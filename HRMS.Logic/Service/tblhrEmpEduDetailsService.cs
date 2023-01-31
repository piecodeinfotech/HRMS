using AutoMapper;
using HRMS.Logic.Database;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Service
{
    public class tblhrEmpEduDetailsService : ItblhrEmployeeEducationDetails
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblhrEmpEduDetailsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
        public void DeleteEmpEduDetails(int id)
        {
            try
            {

                var record = _hRMSContext.EmployeeEducationDetails.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmployeeEducationDetails.Remove(record);
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
    

        public List<tblhrEmployeeEducationDetailsVM> EmpEduDetailsList()
        {
            try
            {
                return _mapper.Map<List<tblhrEmployeeEducationDetailsVM>>(_hRMSContext.EmployeeEducationDetails.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public tblhrEmployeeEducationDetailsVM GetEmpEduDetailsByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblhrEmployeeEducationDetailsVM>(_hRMSContext.EmployeeEducationDetails.Where(x => x.Id == id).FirstOrDefault());
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
        public void SaveEmpEduDetails(tblhrEmployeeEducationDetailsVM obj)
        {
            try
            {
                var edmpEduDetails = _mapper.Map<tblhrEmployeeEducationDetails>(obj);
                _hRMSContext.EmployeeEducationDetails.Add(edmpEduDetails);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdateEmpEduDetails(tblhrEmployeeEducationDetailsVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrEmployeeEducationDetails>(obj);
                var record = _hRMSContext.EmployeeEducationDetails.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmployeeEducationDetails.Update(update);
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
