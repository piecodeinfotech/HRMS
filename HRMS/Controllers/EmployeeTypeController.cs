using HRMS.Helpers;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeTypeController : ControllerBase
    {
        IEmployeeType _employeeType;
        public EmployeeTypeController(IEmployeeType employeeType)
        {
            _employeeType = employeeType;
        }
        #region  EmployeeType API
        Result<EmployeeTypeVM> _Result = new Result<EmployeeTypeVM>();
        [HttpGet]
        public IActionResult GetEmpType()
        {
            Result<List<EmployeeTypeVM>> _Result = new Result<List<EmployeeTypeVM>>();
            try
            {
             _Result.Data=   _employeeType.EmployeeTypeList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpTypeByid(int id)
        {
            try
            {
              _Result.Data=  _employeeType.GetEmployeeTypeByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpType(EmployeeTypeVM obj)
        {
            try
            {
                _employeeType.SaveEmployeeType(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdatedEmpType(EmployeeTypeVM obj)
        {
            try
            {
                _employeeType.UpdateEmployeeType(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult Deletedeapartment(int id)
        {
            try
            {
                _employeeType.DeleteEmployeeType(id);
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
