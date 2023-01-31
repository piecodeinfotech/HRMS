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
    public class tblProfInfoService : ItblProfessionalInformation
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblProfInfoService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteProfInfo(int id)
        {
            try
            {

                var record = _hRMSContext.tblProfessionalInformation.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.tblProfessionalInformation.Remove(record);
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

        public tblProfessionalInformationVM GetProfInfoByid(int id)

        {
            try
            {
                var data = _mapper.Map<tblProfessionalInformationVM>(_hRMSContext.tblProfessionalInformation.Where(x => x.Id == id).FirstOrDefault());
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
        public List<tblProfessionalInformationVM> ProfInfoList()
        {
            try
            {
                return _mapper.Map<List<tblProfessionalInformationVM>>(_hRMSContext.tblProfessionalInformation.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveProfInfo(tblProfessionalInformationVM obj)
        {
            try
            {
                var tblProfInfo = _mapper.Map<tblProfessionalInformation>(obj);
                _hRMSContext.tblProfessionalInformation.Add(tblProfInfo);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateProfInfo(tblProfessionalInformationVM obj)
        {
            try
            {
                var update = _mapper.Map<tblProfessionalInformation>(obj);
                var record = _hRMSContext.tblProfessionalInformation.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.tblProfessionalInformation.Update(update);
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
