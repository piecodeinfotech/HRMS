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
    public class EmpExperienceDetailsService :ItblhrEmpExperienceDetails
    {

        HRMSContext _hRMSContext;
        IMapper _mapper;
        public EmpExperienceDetailsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }

        public tblhrEmpExperienceDetailsVM EmpExpeDetailsById(int id)
        {
            try
            {
                var data = _mapper.Map<tblhrEmpExperienceDetailsVM>(_hRMSContext.Department.Where(x => x.Id == id).FirstOrDefault());
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

        public void DeleteEmpExpeDetails(int id)
        {
            try
            {

                var record = _hRMSContext.EmpExperienceDetails.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmpExperienceDetails.Remove(record);
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

        public void SaveEmpExpeDetails(tblhrEmpExperienceDetailsVM obj)
        {
            try
            {
                var experienceDetails = _mapper.Map<tblhrEmpExperienceDetails>(obj);
                _hRMSContext.EmpExperienceDetails.Add(experienceDetails);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateEmpExpeDetails(tblhrEmpExperienceDetailsVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrEmpExperienceDetails>(obj);
                var record = _hRMSContext.EmpExperienceDetails.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmpExperienceDetails.Update(update);
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

        public List<tblhrEmpExperienceDetailsVM> GetEmpExpeDetails()
        {
            try
            {
                return _mapper.Map<List<tblhrEmpExperienceDetailsVM>>(_hRMSContext.EmpExperienceDetails.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
