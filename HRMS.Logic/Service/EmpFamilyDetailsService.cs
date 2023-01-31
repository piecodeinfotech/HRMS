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
    public class EmpFamilyDetailsService : IEmpFamilydetails
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public EmpFamilyDetailsService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteEmpFamilyDetails(int id)
        {
            try
            {

                var record = _hRMSContext.EmpFamilyDetails.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmpFamilyDetails.Remove(record);
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

        public List<tblhrEmployeeFamilyDetailsVM> EmpFamilyDetailsList()
        {
            try
            {
                return _mapper.Map<List<tblhrEmployeeFamilyDetailsVM>>(_hRMSContext.EmpFamilyDetails.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public tblhrEmployeeFamilyDetailsVM GetEmpFamilyDetailsByid(int id)

        {
            try
            {
                var data = _mapper.Map<tblhrEmployeeFamilyDetailsVM>(_hRMSContext.EmpFamilyDetails.Where(x => x.Id == id).FirstOrDefault());
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


        public void SaveEmpFamilyDetails(tblhrEmployeeFamilyDetailsVM obj)
        {
            try
            {
                var empfamily = _mapper.Map<tblhrEmployeeFamilyDetails>(obj);
                _hRMSContext.EmpFamilyDetails.Add(empfamily);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateEmpFamilyDetails(tblhrEmployeeFamilyDetailsVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrEmployeeFamilyDetails>(obj);
                var record = _hRMSContext.EmpFamilyDetails.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmpFamilyDetails.Update(update);
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
