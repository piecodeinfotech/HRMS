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
    public class ProfessionalInformationService : IProfessionalInformation
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public ProfessionalInformationService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;
           _mapper = mapper;    
        }

        public void DeleteProInfo(int id)
        {
            try
            {

                var record = _hRMSContext.ProfessionalInformation.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.ProfessionalInformation.Remove(record);
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

        public ProfessionalInformationVM GetProInfoByid(int id)
        {
            try
            {
                var data= _mapper.Map<ProfessionalInformationVM>(_hRMSContext.ProfessionalInformation.Where(x => x.Id == id).FirstOrDefault());
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

        public List<ProfessionalInformationVM> ProInfoList()
        {
            try
            {
                return _mapper.Map<List<ProfessionalInformationVM>>(_hRMSContext.ProfessionalInformation.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveProInfo(ProfessionalInformationVM obj)
        {
            try
            {
                var professional = _mapper.Map<ProfessionalInformation>(obj);
                _hRMSContext.ProfessionalInformation.Add(professional);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateProInfo(ProfessionalInformationVM obj)
        {
            try
            {
                var update = _mapper.Map<ProfessionalInformation>(obj);
                var record = _hRMSContext.ProfessionalInformation.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.ProfessionalInformation.Update(update);
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
