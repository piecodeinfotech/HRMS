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
    
    public class CastService : ICast
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public  CastService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext= hRMSContext;
            _mapper= mapper;

        }
        public void CastCreate(CastVM obj)
        {
            try
            {

                var cast = _mapper.Map<Cast>(obj);
                _hRMSContext.Cast.Add(cast);
                _hRMSContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void CastDelete(int id)
        {
            try
            {
                var data = _hRMSContext.Cast.Where(x => x.Id == id).FirstOrDefault();
                if (data != null)
                {
                    _hRMSContext.Remove(data);
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

        public CastVM CastById(int CastId)
        {
            try
            {
                var data = _mapper.Map<CastVM>(_hRMSContext.Cast.Where(x => x.Id == CastId).FirstOrDefault());
                if (data == null)
                {
                    throw new Exception("Invlid Id");
                }
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }

         
        }

        public void CastUpdate(CastVM obj)
        {
            try
            {
                var cast = _mapper.Map<Cast>(obj);
                var record = _hRMSContext.Cast.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Cast.Update(cast);
                    _hRMSContext.SaveChanges();

                }
                else
                {
                    throw new Exception("Record Not Updated");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public List<CastVM> GetCast()
        {
            try
            {
                return _mapper.Map<List<CastVM>>(_hRMSContext.Cast.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
