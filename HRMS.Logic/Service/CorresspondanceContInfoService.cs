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
        
    public class CorresspondanceContInfoService : ICorresspondanceContInfo
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public CorresspondanceContInfoService(HRMSContext hRMSContext, IMapper mapper)
        {
            HRMSContext _hRMSContext;
            IMapper _mapper;
        }

        public List<CorresspondanceContInfoVM> CorreContInfoList()
        {
            return _mapper.Map<List<CorresspondanceContInfoVM>>(_hRMSContext.CorresspondanceContInfo.ToList());
        }

        public void DeleteCorreContInfo(int id)
        {
            try
            {

                var record = _hRMSContext.CorresspondanceContInfo.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.CorresspondanceContInfo.Remove(record);
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

        public CorresspondanceContInfoVM GetCorreContInfoByid(int id)
        {
            try
            {
                var data = _mapper.Map<CorresspondanceContInfoVM>(_hRMSContext.CorresspondanceContInfo.Where(x => x.Id == id).FirstOrDefault());

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
        public void SaveCorreContInfo(CorresspondanceContInfoVM obj)
        {
            try
            {
                var corresspondance = _mapper.Map<CorresspondanceContInfo>(obj);
                _hRMSContext.CorresspondanceContInfo.Add(corresspondance);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdateCorreContInfo(CorresspondanceContInfoVM obj)
        {
            try
            {
                var update = _mapper.Map<CorresspondanceContInfo>(obj);
                var record = _hRMSContext.CorresspondanceContInfo.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.CorresspondanceContInfo.Update(update);
                    _hRMSContext.SaveChanges();

                }
                else
                {
                    throw new Exception("Reocord Not Update");
                }

            }
            catch (Exception)
            {

                throw;
            }



        }


    }
}
