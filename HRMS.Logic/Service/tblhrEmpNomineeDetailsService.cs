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
    public class tblhrEmpNomineeDetailsService : IEmpNomineeDetails
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblhrEmpNomineeDetailsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteEmpNomineeDetails(int id)
        {
            try
            {

                var record = _hRMSContext.EmpNomineeDetails.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmpNomineeDetails.Remove(record);
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

        public List<tblhrEmpNomineeDetailsVM> EmpNomineeDetailsList()
        {
            try
            {
                return _mapper.Map<List<tblhrEmpNomineeDetailsVM>>(_hRMSContext.EmpNomineeDetails.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public tblhrEmpNomineeDetailsVM GetEmpNomineeDetailsByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblhrEmpNomineeDetailsVM>(_hRMSContext.EmpNomineeDetails.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveEmpNomineeDetails(tblhrEmpNomineeDetailsVM obj)
        {
            try
            {
                var department = _mapper.Map<tblhrEmpNomineeDetails>(obj);
                _hRMSContext.EmpNomineeDetails.Add(department);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdateEmpNomineeDetails(tblhrEmpNomineeDetailsVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrEmpNomineeDetails>(obj);
                var record = _hRMSContext.EmpNomineeDetails.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmpNomineeDetails.Update(update);
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
