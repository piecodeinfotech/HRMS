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
    public class PermanentContInfoService : IPermanentContInfo
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public PermanentContInfoService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeletePermanentContInfo(int id)
        {
            try
            {

                var record = _hRMSContext.PermanentContInfo.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.PermanentContInfo.Remove(record);
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

        public tblPermanentContInfoVM GetPermanentContInfoByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblPermanentContInfoVM>(_hRMSContext.PermanentContInfo.Where(x => x.Id == id).FirstOrDefault());
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

        public List<tblPermanentContInfoVM> PermanentContInfoList()
        {
            try
            {
                return _mapper.Map<List<tblPermanentContInfoVM>>(_hRMSContext.PermanentContInfo.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void SavePermanentContInfo(tblPermanentContInfoVM obj)
        {
            try
            {
                var permanentContInfo = _mapper.Map<tblPermanentContInfo>(obj);
                _hRMSContext.PermanentContInfo.Add(permanentContInfo);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdatePermanentContInfo(tblPermanentContInfoVM obj)
        {
            try
            {
                var update = _mapper.Map<tblPermanentContInfo>(obj);
                var record = _hRMSContext.PermanentContInfo.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.PermanentContInfo.Update(update);
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
