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
    public class ProfesInfoAttachService : ItblProfesInfoAttach

    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public ProfesInfoAttachService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteProfesInfoAttach(int id)
        {
            try
            {

                var record = _hRMSContext.tblProfesInfoAttach.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.tblProfesInfoAttach.Remove(record);
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

        public tblProfesInfoAttachVM GetProfesInfoAttachByid(int id)

        {
            try
            {
                var data = _mapper.Map<tblProfesInfoAttachVM>(_hRMSContext.tblProfesInfoAttach.Where(x => x.Id == id).FirstOrDefault());
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

        public List<tblProfesInfoAttachVM> ProfesInfoAttachList()
        {
            try
            {
                return _mapper.Map<List<tblProfesInfoAttachVM>>(_hRMSContext.tblProfesInfoAttach.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveProfesInfoAttach(tblProfesInfoAttachVM obj)
        {
            try
            {
                var tblProfesInfoAttach = _mapper.Map<tblProfesInfoAttach>(obj);
                _hRMSContext.tblProfesInfoAttach.Add(tblProfesInfoAttach);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateProfesInfoAttach(tblProfesInfoAttachVM obj)
        {
            try
            {
                var update = _mapper.Map<tblProfesInfoAttach>(obj);
                var record = _hRMSContext.tblProfesInfoAttach.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.tblProfesInfoAttach.Update(update);
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
