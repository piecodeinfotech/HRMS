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
    public class HigherAuthorityBranchService :IHigherAuthorityBranch
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public HigherAuthorityBranchService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext=hRMSContext;
            _mapper=mapper;

        }

        public void DeleteHighAuthorityBranch(int id)
        {
            try
            {

                var record = _hRMSContext.HigherAuthorityBranch.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.HigherAuthorityBranch.Remove(record);
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

        public HigherAuthorityBranchVM GetHighAuthorityBranchByid(int id)
        {
            try
            {
                var data= _mapper.Map<HigherAuthorityBranchVM>(_hRMSContext.HigherAuthorityBranch.Where(x => x.Id == id).FirstOrDefault());
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

        public List<HigherAuthorityBranchVM> HigherAuthorityBranchList()
        {
            try
            {
                return _mapper.Map<List<HigherAuthorityBranchVM>>(_hRMSContext.HigherAuthorityBranch.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveHigherAuthorityBranch(HigherAuthorityBranchVM obj)
        {
            try
            {
                var higher = _mapper.Map<HigherAuthorityBranch>(obj);
                _hRMSContext.HigherAuthorityBranch.Add(higher);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateHighAuthorityBranch(HigherAuthorityBranchVM obj)
        {
            try
            {
                var update = _mapper.Map<HigherAuthorityBranch>(obj);
                var record = _hRMSContext.HigherAuthorityBranch.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.HigherAuthorityBranch.Update(update);
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
