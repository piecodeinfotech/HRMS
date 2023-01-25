using AutoMapper;
using HRMS.Logic.Database;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Service
{
    public class RegionsService : IRegions
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public RegionsService(HRMSContext hRMSContext,IMapper mapper)
        {

            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
        public void DeleteRegion(int id)
        {
            try
            {

                var record = _hRMSContext.Region.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.Region.Remove(record);
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
        public RegionsVM GetRegionByid(int id)
        {

            try
            {
                var data= _mapper.Map<RegionsVM>(_hRMSContext.Region.Where(x => x.Id == id).FirstOrDefault());
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
        public List<RegionsVM> RegionList()
        {
            try
            {
                var data= _mapper.Map<List<RegionsVM>>(_hRMSContext.Region.ToList());
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
        public void SaveRegion(RegionsVM obj)
        {
            try
            {
                var region = _mapper.Map<Region>(obj);
                _hRMSContext.Region.Add(region);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateRegion(RegionsVM obj)
        {
            try
            {
                var update = _mapper.Map<Region>(obj);
                var record = _hRMSContext.Region.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Region.Update(update);
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
