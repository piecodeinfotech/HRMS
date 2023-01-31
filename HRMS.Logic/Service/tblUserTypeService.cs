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
    public class tblUserTypeService : ItbluserType

    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblUserTypeService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeletetblUserType(int id)
        {
            try
            {

                var record = _hRMSContext.tbluserType.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.tbluserType.Remove(record);
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

        public tblUserTypeVM GettblUserTypeByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblUserTypeVM>(_hRMSContext.tbluserType.Where(x => x.Id == id).FirstOrDefault());
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


        public void SavetblUserType(tblUserTypeVM obj)
        {
            try
            {
                var tbluserType = _mapper.Map<tbluserType>(obj);
                _hRMSContext.tbluserType.Add(tbluserType);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<tblUserTypeVM> tblUserTypeList()
        {
            try
            {
                return _mapper.Map<List<tblUserTypeVM>>(_hRMSContext.tbluserType.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdatetblUserType(tblUserTypeVM obj)
        {
            try
            {
                var update = _mapper.Map<tbluserType>(obj);
                var record = _hRMSContext.tbluserType.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.tbluserType.Update(update);
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
