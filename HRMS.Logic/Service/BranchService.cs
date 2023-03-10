using AutoMapper;
using HRMS.Logic.Database;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Service
{
    public class BranchService : IBranches
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public BranchService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
        public List <BranchesVM> Branchlist()
        {
            try
            {
                return _mapper.Map<List<BranchesVM>>(_hRMSContext.Branches.ToList());

            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void DeleteBranch(int id)
        {
            try
            {
                var data = _hRMSContext.Branches.Where(x => x.Id == id).FirstOrDefault();
                if (data != null)
                {
                    _hRMSContext.Branches.Remove(data);
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

        public BranchesVM GetBrancheByid(int id)
        {
            try
            {
                var data= _mapper.Map<BranchesVM>(_hRMSContext.Branches.Where(x => x.Id == id).FirstOrDefault());
                if (data == null)
                {
                    throw new Exception("Invlid Id");
                }
                return data;
            }

            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveBranch(BranchesVM obj)
        {

            var branch = _mapper.Map<Branches>(obj);
            _hRMSContext.Branches.Add(branch);
            _hRMSContext.SaveChanges();
        }

        public void UpdateBranch(BranchesVM obj)
        {
            try
            {
                var branch = _mapper.Map<Branches>(obj);
                var record = _hRMSContext.Branches.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Branches.Update(branch);
                    _hRMSContext.SaveChanges();

                }
                else
                {
                    throw new Exception("Record Not Updated");
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            
            


        }
    }
}
