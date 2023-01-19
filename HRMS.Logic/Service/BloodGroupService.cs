using AutoMapper;
using HRMS.Logic.Database;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Service
{
    public class BloodGroupService : IBloodGroup
    {
        private readonly IMapper _mapper;
        HRMSContext _hRMSContext;
        public BloodGroupService(HRMSContext hRMSContext, IMapper mapper  )
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }

        public void BloodCreate(BloodGroupVM obj)
        {
            try
            {
                var bloodGroup = _mapper.Map<BloodGroup>(obj);
                _hRMSContext.BloodGroup.Add(bloodGroup);
                _hRMSContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

          
        }

        public void BloodDelete(int id)
        {
            try
            {
                var data = _hRMSContext.BloodGroup.Where(x => x.Id == id).FirstOrDefault();
                if (data != null)
                {

                    _hRMSContext.BloodGroup.Remove(data);
                    _hRMSContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public BloodGroupVM BloodGroupById(int BloodGroupId)
        {
            try
            {
                return _mapper.Map<BloodGroupVM>(_hRMSContext.BloodGroup.Where(x => x.Id == BloodGroupId).FirstOrDefault());
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public void BloodUpdate(BloodGroupVM obj)
        {
            try
            {
                BloodGroup blood = new BloodGroup();

                blood = _hRMSContext.BloodGroup.Where(x => x.Id == obj.Id).FirstOrDefault();

                if (blood != null)
                {
                    _mapper.Map<BloodGroup>(obj);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
           
        }

        public List<BloodGroupVM> GetBloodGroups()
        {
            try
            {
                return _mapper.Map<List<BloodGroupVM>>(_hRMSContext.BloodGroup.ToList());

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
