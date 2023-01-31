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
    public class MaritalStatusService : ItblMaritalStatus
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public MaritalStatusService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteMaritalStatus(int id)
        {
            try
            {

                var record = _hRMSContext.MaritalStatus.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.MaritalStatus.Remove(record);
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

        public tblMaritalStatusVM GetMaritalStatusByid(int id)

        {
            try
            {
                var data = _mapper.Map<tblMaritalStatusVM>(_hRMSContext.MaritalStatus.Where(x => x.Id == id).FirstOrDefault());
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


        public List<tblMaritalStatusVM> MaritalStatusList()
        {
            try
            {
                return _mapper.Map<List<tblMaritalStatusVM>>(_hRMSContext.MaritalStatus.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void SaveMaritalStatus(tblMaritalStatusVM obj)
        {
            try
            {
                var maritalStatus = _mapper.Map<tblMaritalStatus>(obj);
                _hRMSContext.MaritalStatus.Add(maritalStatus);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdateMaritalStatus(tblMaritalStatusVM obj)
        {
            try
            {
                var update = _mapper.Map<tblMaritalStatus>(obj);
                var record = _hRMSContext.MaritalStatus.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.MaritalStatus.Update(update);
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
