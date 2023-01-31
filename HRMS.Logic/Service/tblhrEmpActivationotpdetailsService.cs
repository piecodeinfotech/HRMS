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
    public class tblhrEmpActivationotpdetailsService : ItblhrEmpActivationOTPdetails
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblhrEmpActivationotpdetailsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }


        public void DeleteEmpActiOtpdetails(int id)
        {
            try
            {

                var record = _hRMSContext.EmpActivationOtpdetails.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmpActivationOtpdetails.Remove(record);
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

        public List<tblhrEmpActivationotpdetailsVM> EmpActiOtpdetailsList()
        {
            try
            {
                return _mapper.Map<List<tblhrEmpActivationotpdetailsVM>>(_hRMSContext.EmpActivationOtpdetails.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public tblhrEmpActivationotpdetailsVM GetEmpActiOtpdetailsByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblhrEmpActivationotpdetailsVM>(_hRMSContext.EmpActivationOtpdetails.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveEmpActiOtpdetails(tblhrEmpActivationotpdetailsVM obj)
        {
            try
            {
                var EmpActivationOtpdetails = _mapper.Map<tblhrEmpActivationOtpdetails>(obj);
                _hRMSContext.EmpActivationOtpdetails.Add(EmpActivationOtpdetails);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateEmpActiOtpdetails(tblhrEmpActivationotpdetailsVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrEmpActivationOtpdetails>(obj);
                var record = _hRMSContext.EmpActivationOtpdetails.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmpActivationOtpdetails.Update(update);
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
