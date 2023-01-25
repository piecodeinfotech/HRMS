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
    public class HigherAuthorityService : IHigherAuthority
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public HigherAuthorityService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
    
        public void DeleteHigherAuthority(int id)
        {
            try
            {

                var record = _hRMSContext.HigherAuthority.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.HigherAuthority.Remove(record);
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

        public HigherAuthorityVM GetHigherAuthorityByid(int id)
        {
            try
            {
                var data = _mapper.Map<HigherAuthorityVM>(_hRMSContext.HigherAuthority.Where(x => x.Id == id).FirstOrDefault());
                
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
        public List<HigherAuthorityVM> HigherAuthorityList()
        {
            try
            {
             return    _mapper.Map<List<HigherAuthorityVM>>(_hRMSContext.HigherAuthority.ToList());
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveHigherAuthority(HigherAuthorityVM obj)
        {
            try
            {
                var higherAuthority = _mapper.Map<HigherAuthority>(obj);
                _hRMSContext.HigherAuthority.Add(higherAuthority);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateHigherAuthority(HigherAuthorityVM obj)
        {
            try
            {
                var update = _mapper.Map<HigherAuthority>(obj);
                var record = _hRMSContext.HigherAuthority.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.HigherAuthority.Update(update);
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