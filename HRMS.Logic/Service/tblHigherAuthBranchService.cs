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
    public class tblHigherAuthBranchService :ItblHigherAuthorityBranch

    {
        HRMSContext _hRMSContext;
        IMapper _mapper;

        public tblHigherAuthBranchService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;   
        }

        public void DeletetblHigherAuthBranch(int id)
        {
            try
            {

                var record = _hRMSContext.tblHigherAuthorityBranch.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.tblHigherAuthorityBranch.Remove(record);
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

        public tbl_HigherAuthorityBranchVM GettblHigherAuthBranchByid(int id)
        {
            try
            {
                var data = _mapper.Map<tbl_HigherAuthorityBranchVM>(_hRMSContext.tblHigherAuthorityBranch.Where(x => x.Id == id).FirstOrDefault());

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

        public void SavetblHigherAuthBranch(tbl_HigherAuthorityBranchVM obj)
        {
            try
            {
                var tblHigherAuthBranch = _mapper.Map<tblHigherAuthorityBranch>(obj);
                _hRMSContext.tblHigherAuthorityBranch.Add(tblHigherAuthBranch);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<tbl_HigherAuthorityBranchVM> tblHigherAuthBranchList()
        {
            return _mapper.Map<List<tbl_HigherAuthorityBranchVM>>(_hRMSContext.tblHigherAuthorityBranch.ToList());
        }


        public void UpdatetblHigherAuthBranch(tbl_HigherAuthorityBranchVM obj)
        {
            try
            {

                var update = _mapper.Map<tblHigherAuthorityBranch>(obj);
                var record = _hRMSContext.tblHigherAuthorityBranch.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.tblHigherAuthorityBranch.Update(update);
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
