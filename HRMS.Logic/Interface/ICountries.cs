using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ICountries
    {
        void SaveCountries(CountriesVM obj);
        void UpdateCountries(CountriesVM obj);
        void Deletecountries(int id);
       CountriesVM GetCountriesByid(int id);
        List<CountriesVM> Countrieslist();  

    }
}
