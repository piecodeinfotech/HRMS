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
    public class ThirdPartyService :IThirdParty
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public ThirdPartyService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
        #region  ThirdParty API
        public void DeleteThirdParty(int id)
        {
            try
            {

                var record = _hRMSContext.ThirdParty.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.ThirdParty.Remove(record);
                    _hRMSContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Record NOt Found");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ThirdPartyVM GetThirdPartyByid(int id)
        {
            try
            {
                var data = _mapper.Map<ThirdPartyVM>(_hRMSContext.ThirdParty.Where(x => x.Id == id).FirstOrDefault());

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

        public void SaveThirdParty(ThirdPartyVM obj)
        {
            try
            {
                var thirdParty = _mapper.Map<ThirdParty>(obj);
                _hRMSContext.ThirdParty.Add(thirdParty);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<ThirdPartyVM> ThirdPartyList()
        {
            return _mapper.Map<List<ThirdPartyVM>>(_hRMSContext.ThirdParty.ToList());
        }

        public void UpdateThirdParty(ThirdPartyVM obj)
        {
            try
            {

                var update = _mapper.Map<ThirdParty>(obj);
                var record = _hRMSContext.ThirdParty.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.ThirdParty.Update(update);
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
        #endregion
    }
}
