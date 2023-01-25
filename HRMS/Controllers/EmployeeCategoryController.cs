using HRMS.Helpers;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeCategoryController : ControllerBase
    {
        IEmployeeCategory _employeeCategory;
        public EmployeeCategoryController(IEmployeeCategory employee)
        {
            _employeeCategory = employee;   

        }
        #region  EmployeeCategotry API
        Result<EmployeeCategoryVM> _Result = new Result<EmployeeCategoryVM>();
        [HttpGet]
        public IActionResult GetEmpcategory()
        {
            Result<List<EmployeeCategoryVM>> _Result = new Result<List<EmployeeCategoryVM>>();
            try
            {
                _Result.Data = _employeeCategory.EmployeeCategoryList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpcategoryByid(int id)
        {
            try
            {
              _Result.Data=  _employeeCategory.GetEmployeeCategoryByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpcategory(EmployeeCategoryVM obj)
        {
            try
            {
                _employeeCategory.SaveEmployeeCategory(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateEmployeeCategory(EmployeeCategoryVM obj)
        {
            try
            {
                _employeeCategory.UpdateEmployeeCategory(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult Deletedistricts(int id)
        {
            try
            {
                _employeeCategory.DeleteEmployeeCategory(id);
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
