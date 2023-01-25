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
    public class CountriesService : ICountries
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;

        public CountriesService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
        public List<CountriesVM> Countrieslist()
        {
            try
            {
                return _mapper.Map<List<CountriesVM>>(_hRMSContext.Countries.ToList());

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void Deletecountries(int id)
        {
            try
            {
                var data = _hRMSContext.Countries.Where(x => x.Id == id).FirstOrDefault();
                if (data != null)
                {
                    _hRMSContext.Countries.Remove(data);
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

        public CountriesVM GetCountriesByid(int id)
        {
            try
            {
                var data = _mapper.Map<CountriesVM>(_hRMSContext.Countries.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveCountries(CountriesVM obj)
        {
            try
            {
                var data = _mapper.Map<Countries>(obj);
                _hRMSContext.Countries.Add(data);
                _hRMSContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public void UpdateCountries(CountriesVM obj)
        {
            try
            {

                var countries = _mapper.Map<Countries>(obj);
                var record = _hRMSContext.Countries.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Countries.Update(countries);
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
