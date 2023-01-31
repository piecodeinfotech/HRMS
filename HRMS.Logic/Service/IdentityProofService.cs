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
    public class IdentityProofService : IIdentityProof
    {

        HRMSContext _hRMSContext;
        IMapper _mapper;
        public IdentityProofService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteIdentityProof(int id)
        {
            try
            {

                var record = _hRMSContext.IdentityProof.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.IdentityProof.Remove(record);
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
        public tblIdentityProofVM GetIdentityProofByid(int id)

        {
            try
            {
                var data = _mapper.Map<tblIdentityProofVM>(_hRMSContext.IdentityProof.Where(x => x.Id == id).FirstOrDefault());
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
        public List<tblIdentityProofVM> IdentityProofList()
        {
            try
            {
                return _mapper.Map<List<tblIdentityProofVM>>(_hRMSContext.IdentityProof.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveIdentityProof(tblIdentityProofVM obj)
        {
            try
            {
                var tblIdentityProof = _mapper.Map<tblIdentityProof>(obj);
                _hRMSContext.IdentityProof.Add(tblIdentityProof);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateIdentityProof(tblIdentityProofVM obj)
        {
            try
            {
                var update = _mapper.Map<tblIdentityProof>(obj);
                var record = _hRMSContext.IdentityProof.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.IdentityProof.Update(update);
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
