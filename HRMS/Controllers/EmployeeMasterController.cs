using HRMS.Helpers;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeMasterController : ControllerBase
    {
        IEmployeeMaster _employeeMaster;

        public EmployeeMasterController(IEmployeeMaster employeeMaster)
        {
            _employeeMaster = employeeMaster;   
        }
        #region  EmployeeMaster API
        Result<EmployeeMasterVM> _Result = new Result<EmployeeMasterVM>();
        [HttpGet]
        public IActionResult GetEmployeeMaster()
        {
            Result<List<EmployeeMasterVM>> _Result = new Result<List<EmployeeMasterVM>>();

            try
            {
                _Result.Data = _employeeMaster.EmployeeMasterList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmployeeMasterByid(int id)
        {
            try
            {
                _Result.Data = _employeeMaster.GetEmployeeMasterByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmployeeMaster(EmployeeMasterVM obj)
        {
            try
            {
                _employeeMaster.SaveEmployeeMaster(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateEmployeeMaster(EmployeeMasterVM obj)
        {
            try
            {
                _employeeMaster.UpdateEmployeeMaster(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEmployeeMaster(int id)
        {
            try
            {
                _employeeMaster.DeleteEmployeeMaster(id);
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
