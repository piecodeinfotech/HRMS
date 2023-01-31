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
    public class tblIdentityTypeService : IIdentityType

    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblIdentityTypeService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteIdentityType(int id)
        {
            try
            {

                var record = _hRMSContext.IdentityType.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.IdentityType.Remove(record);
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


        public List<tblIdentityTypeVM> IdentityTypeList()
        {
            try
            {
                return _mapper.Map<List<tblIdentityTypeVM>>(_hRMSContext.IdentityType.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public tblIdentityTypeVM GetIdentityTypeByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblIdentityTypeVM>(_hRMSContext.IdentityType.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveIdentityType(tblIdentityTypeVM obj)
        {
            try
            {
                var tblIdentityType = _mapper.Map<tblIdentityType>(obj);
                _hRMSContext.IdentityType.Add(tblIdentityType);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void UpdateIdentityType(tblIdentityTypeVM obj)
        {
            try
            {
                var update = _mapper.Map<tblIdentityType>(obj);
                var record = _hRMSContext.IdentityType.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.IdentityType.Update(update);
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
