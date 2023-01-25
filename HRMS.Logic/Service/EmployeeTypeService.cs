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
    public class EmployeeTypeService : IEmployeeType
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public EmployeeTypeService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }

        public void DeleteEmployeeType(int id)
        {
            try
            {

                var record = _hRMSContext.EmployeeType.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmployeeType.Remove(record);
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

        public List<EmployeeTypeVM> EmployeeTypeList()
        {
            try
            {
                return _mapper.Map<List<EmployeeTypeVM>>(_hRMSContext.EmployeeType.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public EmployeeTypeVM GetEmployeeTypeByid(int id)
        {
            try
            {
                var data = _mapper.Map<EmployeeTypeVM>(_hRMSContext.EmployeeType.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveEmployeeType(EmployeeTypeVM obj)
        {
            try
            {
                var employee = _mapper.Map<EmployeeType>(obj);
                _hRMSContext.EmployeeType.Add(employee);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateEmployeeType(EmployeeTypeVM obj)
        {
            try
            {
                var update = _mapper.Map<EmployeeType>(obj);
                var record = _hRMSContext.EmployeeType.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmployeeType.Update(update);
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
