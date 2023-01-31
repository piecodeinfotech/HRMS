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
    public class DepartmentService : IDepartment
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public DepartmentService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }

        #region


        public void DeleteDeapartment(int id)
        {
            try
            {

                var record = _hRMSContext.Department.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.Department.Remove(record);
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

        public List<DepartmentVM> DepartmentList()
        {
            try
            {
                return _mapper.Map<List<DepartmentVM>>(_hRMSContext.Department.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DepartmentVM GetDeapartmentByid(int id)

        {
            try
            {
                var data = _mapper.Map<DepartmentVM>(_hRMSContext.Department.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveDeapartment(DepartmentVM obj)
        {
            try
            {
                var department = _mapper.Map<Department>(obj);
                _hRMSContext.Department.Add(department);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateDeapartment(DepartmentVM obj)
        {
            try
            {
                var update = _mapper.Map<Department>(obj);
                var record = _hRMSContext.Department.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Department.Update(update);
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
