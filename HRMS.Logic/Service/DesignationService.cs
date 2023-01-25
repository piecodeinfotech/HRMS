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

    public class DesignationService : IDesignation
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public DesignationService(HRMSContext hRMSContext, IMapper mapper)
        {
           _hRMSContext = hRMSContext;
            _mapper = mapper;   
        }
        #region
        public void DeleteDesignation(int id)
        {
            try
            {

                var record = _hRMSContext.Designation.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.Designation.Remove(record);
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

        public List<DesignationVM> DesignationList()
        {
            try
            {
                return _mapper.Map<List<DesignationVM>>(_hRMSContext.Designation.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DesignationVM GetDesignationByid(int id)
        {
            try
            {
                var data= _mapper.Map<DesignationVM>(_hRMSContext.Designation.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveDesignation(DesignationVM obj)
        {
            try
            {
                var designation = _mapper.Map<Designation>(obj);
                _hRMSContext.Designation.Add(designation);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateDesignation(DesignationVM obj)
        {
            try
            {
                var update = _mapper.Map<Designation>(obj);
                var record = _hRMSContext.Designation.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Designation.Update(update);
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
