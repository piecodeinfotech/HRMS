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
    public class HigherAuthorityNameService : IHigherAuthorityName
    {

        HRMSContext _hRMSContext;
        IMapper _mapper;
        public HigherAuthorityNameService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext=hRMSContext;   
            _mapper=mapper;
           
            
        }
        public void DeleteHighAuthName(int id)
        {
            try
            {

                var record = _hRMSContext.HigherAuthorityName.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.HigherAuthorityName.Remove(record);
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

        public List<HigherAuthorityNameVM> HighAuthNameList()
        {
          return  _mapper.Map<List<HigherAuthorityNameVM>>(_hRMSContext.HigherAuthorityName.ToList());
        }

        public HigherAuthorityNameVM GetHighAuthNameByid(int id)
        {
            try
            {
                var data = _mapper.Map<HigherAuthorityNameVM>(_hRMSContext.HigherAuthorityName.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveHighAuthName(HigherAuthorityNameVM obj)
        {
            try
            {
                var higherAuthorityName = _mapper.Map<HigherAuthorityName>(obj);
                _hRMSContext.HigherAuthorityName.Add(higherAuthorityName);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateHighAuthName(HigherAuthorityNameVM obj)
        {
            try
            {
                var update = _mapper.Map<HigherAuthorityName>(obj);
                var record = _hRMSContext.HigherAuthorityName.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.HigherAuthorityName.Update(update);
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

