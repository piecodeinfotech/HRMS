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
    public class CompaniesService : ICompanies
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public CompaniesService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;

            _mapper = mapper;

        }
        #region
       
        public List<CompaniesVM> Companieslist()
        {
            try
            {
                return _mapper.Map<List<CompaniesVM>>(_hRMSContext.Companies.ToList());

            }
            catch (Exception ex)
            {

                throw;
            }



        }

        public void DeleteCompanies(int id)
        {
            try
            {
                var record = _hRMSContext.Companies.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.Companies.Remove(record);
                    _hRMSContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Record Not found");
                }


            }
            catch (Exception ex)
            {

                throw;
            }
          
        }

        public CompaniesVM GetCompaniesByid(int id)
        {
            try
            {
                var data = _mapper.Map<CompaniesVM>(_hRMSContext.Companies.Where(x => x.Id == id).FirstOrDefault());
                if (data == null)
                {
                    throw new Exception("Record Not found");

                }
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }

           
        }

        public void SaveCompanies(CompaniesVM obj)
        {
            try
            {
                var companies = _mapper.Map<Companies>(obj);
                _hRMSContext.Companies.Add(companies);
                _hRMSContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }

        public void UpdateCompanies(CompaniesVM obj)
        {
            try
            {
                var update = _mapper.Map<Companies>(obj);

                var record = _hRMSContext.Companies.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Companies.Update(update);
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
        #endregion
    }
}
