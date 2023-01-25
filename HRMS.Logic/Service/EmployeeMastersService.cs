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
    public class EmployeeMastersService : IEmployeeMaster
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public EmployeeMastersService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
        public void DeleteEmployeeMaster(int id)
        {
            try
            {

                var record = _hRMSContext.EmployeeMaster.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmployeeMaster.Remove(record);
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

        public List<EmployeeMasterVM> EmployeeMasterList()
        {
            throw new NotImplementedException();
        }

        public EmployeeMasterVM GetEmployeeMasterByid(int id)
        {
            try
            {
                var data = _mapper.Map<EmployeeMasterVM>(_hRMSContext.EmployeeMaster.Where(x => x.Id == id).FirstOrDefault());

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


        public void SaveEmployeeMaster(EmployeeMasterVM obj)
        {
            try
            {
                var employeeMaster = _mapper.Map<EmployeeMaster>(obj);
                _hRMSContext.EmployeeMaster.Add(employeeMaster);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void UpdateEmployeeMaster(EmployeeMasterVM obj)
        {
            try
            {
                var update = _mapper.Map<EmployeeMaster>(obj);
                var record = _hRMSContext.EmployeeMaster.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmployeeMaster.Update(update);
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
