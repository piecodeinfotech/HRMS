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
    public class tblhrEmployeeEducationsService : IEmployeeEducations
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblhrEmployeeEducationsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteEmpEducations(int id)
        {
            try
            {

                var record = _hRMSContext.EmployeeEducations.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmployeeEducations.Remove(record);
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
        public List<tblhrEmployeeEducationsVM> EmpEducationsList()
        {
            try
            {
                return _mapper.Map<List<tblhrEmployeeEducationsVM>>(_hRMSContext.EmployeeEducations.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public tblhrEmployeeEducationsVM GetEmpEducationsByid(int id)

        {
            try
            {
                var data = _mapper.Map<tblhrEmployeeEducationsVM>(_hRMSContext.EmployeeEducations.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveEmpEducations(tblhrEmployeeEducationsVM obj)
        {
            try
            {
                var empeducations = _mapper.Map<tblhrEmployeeEducations>(obj);
                _hRMSContext.EmployeeEducations.Add(empeducations);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateEmpEducations(tblhrEmployeeEducationsVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrEmployeeEducations>(obj);
                var record = _hRMSContext.EmployeeEducations.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmployeeEducations.Update(update);
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
