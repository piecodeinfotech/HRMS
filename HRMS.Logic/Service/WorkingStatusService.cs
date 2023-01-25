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
    public class WorkingStatusService : IWorkingStatus
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public WorkingStatusService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
        public List<WorkingStatusVM> WorkingStatusList()
        {
            return _mapper.Map<List<WorkingStatusVM>>(_hRMSContext.WorkingStatus.ToList());
        }
        public void DeleteWorkingStatus(int id)
        {
            try
            {

                var record = _hRMSContext.WorkingStatus.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.WorkingStatus.Remove(record);
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

        public WorkingStatusVM GetWorkingStatusByid(int id)
        {
            try
            {
                var data = _mapper.Map<WorkingStatusVM>(_hRMSContext.WorkingStatus.Where(x => x.Id == id).FirstOrDefault());

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

        public void SaveWorkingStatus(WorkingStatusVM obj)
        {
            try
            {
                var working = _mapper.Map<WorkingStatus>(obj);
                _hRMSContext.WorkingStatus.Add(working);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateWorkingStatus(WorkingStatusVM obj)
        {
            try
            {
                var update = _mapper.Map<WorkingStatus>(obj);
                var record = _hRMSContext.UserType.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.WorkingStatus.Update(update);
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
