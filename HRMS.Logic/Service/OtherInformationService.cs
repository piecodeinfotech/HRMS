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
    public class OtherInformationService : IOtherInformation
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public OtherInformationService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteOtherInformation(int id)
        {
            try
            {

                var record = _hRMSContext.OtherInformation.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.OtherInformation.Remove(record);
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

        public tblOtherInformationVM GetOtherInformationByid(int id)

        {
            try
            {
                var data = _mapper.Map<tblOtherInformationVM>(_hRMSContext.OtherInformation.Where(x => x.Id == id).FirstOrDefault());
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

        public List<tblOtherInformationVM> OtherInformationList()
        {
            try
            {
                return _mapper.Map<List<tblOtherInformationVM>>(_hRMSContext.OtherInformation.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void SaveOtherInformation(tblOtherInformationVM obj)
        {
            try
            {
                var otherInformation = _mapper.Map<tblOtherInformation>(obj);
                _hRMSContext.OtherInformation.Add(otherInformation);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdateOtherInformation(tblOtherInformationVM obj)
        {
            try
            {
                var update = _mapper.Map<tblOtherInformation>(obj);
                var record = _hRMSContext.Department.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.OtherInformation.Update(update);
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
