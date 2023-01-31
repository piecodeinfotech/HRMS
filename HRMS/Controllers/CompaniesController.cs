using HRMS.Helpers;
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
    public class CompaniesController : ControllerBase
    {
        ICompanies _companies;
        public CompaniesController(ICompanies companies)
        {
            _companies = companies;
        }
        Result<CompaniesVM> _Result = new Result<CompaniesVM>();

        [HttpGet]
        public IActionResult Getcompanies()

        {
            Result<List<CompaniesVM>> _Result = new Result<List<CompaniesVM>>();
            try
            {
             _Result.Data = _companies.Companieslist();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetcompanieByid(int id)

        {
            try
            {
           _Result.Data = _companies.GetCompaniesByid(id);

                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }

        [HttpDelete]
        public IActionResult Deletecompanie(int id)

        {
            try
            {
                _companies.DeleteCompanies(id);
                _Result.IsSuccess = true;
               


            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }

        [HttpPost]
        public IActionResult Savecompanies(CompaniesVM obj)

        {
            try
            {
                _companies.SaveCompanies(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult Updatecompanies(CompaniesVM obj)

        {
            try
            {
                _companies.UpdateCompanies(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }




    }
}
