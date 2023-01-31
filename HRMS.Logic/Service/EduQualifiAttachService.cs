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
    public class EduQualifiAttachService :ItblEduQualifiAttach

    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public EduQualifiAttachService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }

        public void DeleteEduQualifiAttach(int id)
        {
            try
            {

                var record = _hRMSContext.EduQualifiAttach.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EduQualifiAttach.Remove(record);
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

        public List<tblEducQualifiAttachVM> EduQualifiAttachList()
        {
            return _mapper.Map<List<tblEducQualifiAttachVM>>(_hRMSContext.EduQualifiAttach.ToList());
        }

        public tblEducQualifiAttachVM GetEduQualifiAttachByid(int id)
        {
            try
            {
                var data = _mapper.Map<tblEducQualifiAttachVM>(_hRMSContext.EduQualifiAttach.Where(x => x.Id == id).FirstOrDefault());

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

        public void SaveEduQualifiAttach(tblEducQualifiAttachVM obj)
        {
            try
            {
                var educQualifi = _mapper.Map<tblEducQualifiAttach>(obj);
                _hRMSContext.EduQualifiAttach.Add(educQualifi);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateEduQualifiAttach(tblEducQualifiAttachVM obj)
        {
            try
            {
                var update = _mapper.Map<tblEducQualifiAttach>(obj);
                var record = _hRMSContext.EduQualifiAttach.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EduQualifiAttach.Update(update);
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

