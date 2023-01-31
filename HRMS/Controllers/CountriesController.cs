using HRMS.Helpers;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        ICountries _countries;
        public CountriesController(ICountries countries)
        {
            _countries=countries;
        }
        #region Countries API
        Result<CountriesVM> _Result = new Result<CountriesVM>();
        [HttpGet]
        public IActionResult Getcountries()
        {
            Result<List<CountriesVM>> _Result = new Result<List<CountriesVM>>();
            try
            {
              _Result.Data=  _countries.Countrieslist();
              
            }
            catch (Exception ex)
            {
                _Result.Message = ex.Message;

            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetcountriesByid(int id)
        {
            try
            {
              _Result.Data=  _countries.GetCountriesByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult Savecountries(CountriesVM obj)
        {
            try
            {
                 _countries.SaveCountries(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult Updatecountries(CountriesVM obj)
        {
            try
            {
                _countries.UpdateCountries(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex) 
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult Deletecountries(int id)
        {
            try
            {
                _countries.Deletecountries(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        #endregion


    }
}
