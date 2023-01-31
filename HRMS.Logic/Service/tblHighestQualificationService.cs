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
    public class tblHighestQualificationService : Itbl_HighestQualification
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblHighestQualificationService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public List<tbl_HighestQualificationVM> Get_tblHighQualifiList()
        {
            return _mapper.Map<List<tbl_HighestQualificationVM>>(_hRMSContext.tblHighestQualification.ToList());
        }


        public tbl_HighestQualificationVM Get_tblHighQualifiById(int id)
        {
            try
            {
                var data = _mapper.Map<tbl_HighestQualificationVM>(_hRMSContext.tblHighestQualification.Where(x => x.Id == id).FirstOrDefault());

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


        public void Delete_tblHighQualifi(int id)
        {
            try
            {

                var record = _hRMSContext.tblHighestQualification.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.tblHighestQualification.Remove(record);
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
        public void Save_tblHighQualifi(tbl_HighestQualificationVM obj)
        {
            try
            {
                var tblHighestQualification = _mapper.Map<tbl_HighestQualification>(obj);
                _hRMSContext.tblHighestQualification.Add(tblHighestQualification);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Update_tblHighQualifi(tbl_HighestQualificationVM obj)
        {
            try
            {

                var update = _mapper.Map<tbl_HighestQualification>(obj);
                var record = _hRMSContext.tblHighestQualification.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.tblHighestQualification.Update(update);
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
