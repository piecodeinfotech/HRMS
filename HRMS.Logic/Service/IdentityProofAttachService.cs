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
    public class IdentityProofAttachService : IIdentityProofAttach
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public IdentityProofAttachService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteIdentityProofAttach(int id)
        {
            try
            {

                var record = _hRMSContext.IdentityProofAttach.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.IdentityProofAttach.Remove(record);
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

        public tblIdentityProofAttachVM GetIdentityProofAttachByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblIdentityProofAttachVM>(_hRMSContext.IdentityProofAttach.Where(x => x.Id == id).FirstOrDefault());
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

        public List<tblIdentityProofAttachVM> IdentityProofAttachList()
        {
            try
            {
                return _mapper.Map<List<tblIdentityProofAttachVM>>(_hRMSContext.IdentityProofAttach.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveIdentityProofAttach(tblIdentityProofAttachVM obj)
        {
            try
            {
                var tblIdentityProofAttach = _mapper.Map<tblIdentityProofAttach>(obj);
                _hRMSContext.IdentityProofAttach.Add(tblIdentityProofAttach);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void UpdateIdentityProofAttach(tblIdentityProofAttachVM obj)
        {
            try
            {
                var update = _mapper.Map<tblIdentityProofAttach>(obj);
                var record = _hRMSContext.IdentityProofAttach.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.IdentityProofAttach.Update(update);
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
