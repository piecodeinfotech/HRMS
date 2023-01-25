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
    public class StatesService : IStates
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public StatesService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        #region  States API
        public void DeleteStates(int id)
        {
            try
            {

                var record = _hRMSContext.States.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.States.Remove(record);
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
        public StatesVM GetStatesByid(int id)
        {
            try
            {
                var data = _mapper.Map<StatesVM>(_hRMSContext.States.Where(x => x.Id == id).FirstOrDefault());

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
       

        public void SaveStates(StatesVM obj)
        {
            try
            {
                var states = _mapper.Map<States>(obj);
                _hRMSContext.States.Add(states);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<StatesVM> StatesList()
        {
            return _mapper.Map<List<StatesVM>>(_hRMSContext.States.ToList());
        }

        public void UpdateStates(StatesVM obj)
        {
            try
            {

                var update = _mapper.Map<States>(obj);
                var record = _hRMSContext.States.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.States.Update(update);
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
