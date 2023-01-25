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
    public class DistrictsService : IDistricts
    {


        HRMSContext _hRMSContext;
        IMapper _mapper;

        public DistrictsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
        #region  Districts API

        public void DeleteDistricts(int id)
        {
            try
            {

                var record = _hRMSContext.Districts.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.Districts.Remove(record);
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

        public List<DistrictsVM> DistrictsList()
        {
            try
            {
                return _mapper.Map<List<DistrictsVM>>(_hRMSContext.Districts.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DistrictsVM GetDistrictsByid(int id)
        {
            try
            {
                var data = _mapper.Map<DistrictsVM>(_hRMSContext.Districts.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveDistricts(DistrictsVM obj)
        {
            try
            {
                var districts = _mapper.Map<Districts>(obj);
                _hRMSContext.Districts.Add(districts);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateDistricts(DistrictsVM obj)
        {
            try
            {
                var update = _mapper.Map<Districts>(obj);
                var record = _hRMSContext.Districts.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Districts.Update(update);
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
            #endregion
        }
    }
}
