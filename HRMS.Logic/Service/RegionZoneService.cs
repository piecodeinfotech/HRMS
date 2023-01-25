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
    public class RegionZoneService : IRegionZone
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;

        public RegionZoneService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;   

        }
        public void DeleteRegionZone(int id)
        {
            try
            {

                var record = _hRMSContext.RegionZone.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.RegionZone.Remove(record);
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
        public RegionZoneVM GetRegionZoneByid(int id)
        {
            try
            {
                var data= _mapper.Map<RegionZoneVM>(_hRMSContext.RegionZone.Where(x => x.Id == id).FirstOrDefault());

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

        public List<RegionZoneVM> RegionZoneList()
        {

            try
            {
                return _mapper.Map<List<RegionZoneVM>>(_hRMSContext.RegionZone.ToList());

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveRegionZone(RegionZoneVM obj)
        {
            try
            {
                var region = _mapper.Map<RegionZone>(obj);
                _hRMSContext.RegionZone.Add(region);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateRegionZone(RegionZoneVM obj)
        {
            try
            {
                var update = _mapper.Map<RegionZone>(obj);
                var record = _hRMSContext.RegionZone.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.RegionZone.Update(update);
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