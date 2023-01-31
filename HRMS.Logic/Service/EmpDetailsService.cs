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
    public class EmpDetailsService : ItblhrEmployeeDetails
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public EmpDetailsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteEmpDetails(int id)
        {
            try
            {

                var record = _hRMSContext.tblhrEmployeeDetails.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.tblhrEmployeeDetails.Remove(record);
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

        public List<tblhrEmployeeDetailsVM> EmpDetailsList()
        {
            try
            {
                return _mapper.Map<List<tblhrEmployeeDetailsVM>>(_hRMSContext.tblhrEmployeeDetails.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public tblhrEmployeeDetailsVM GetEmpDetailsByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblhrEmployeeDetailsVM>(_hRMSContext.tblhrEmployeeDetails.Where(x => x.Id == id).FirstOrDefault());
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


        public void SaveEmpDetails(tblhrEmployeeDetailsVM obj)
        {
            try
            {
                var tblhrEmployeeDetails = _mapper.Map<tblhrEmployeeDetails>(obj);
                _hRMSContext.tblhrEmployeeDetails.Add(tblhrEmployeeDetails);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void UpdateEmpDetails(tblhrEmployeeDetailsVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrEmployeeDetails>(obj);
                var record = _hRMSContext.tblhrEmployeeDetails.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.tblhrEmployeeDetails.Update(update);
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
