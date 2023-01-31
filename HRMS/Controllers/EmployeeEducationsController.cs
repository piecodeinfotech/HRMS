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
    public class EmployeeEducationsController : ControllerBase
    {
        IEmployeeEducations _employeeEducations;
        public EmployeeEducationsController(IEmployeeEducations employeeEducations)
        {
            _employeeEducations = employeeEducations;   
        }
        #region  EmployeeEducations API
        Result<tblhrEmployeeEducationsVM> _Result = new Result<tblhrEmployeeEducationsVM>();

        [HttpGet]
        public IActionResult GetEmpEducations()
        {
            Result<List<tblhrEmployeeEducationsVM>> _Result = new Result<List<tblhrEmployeeEducationsVM>>();
            try
            {
                _Result.Data = _employeeEducations.EmpEducationsList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpEducationsByid(int id)
        {
            try
            {
                _Result.Data = _employeeEducations.GetEmpEducationsByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpEducations(tblhrEmployeeEducationsVM obj)
        {
            try
            {
                _employeeEducations.SaveEmpEducations(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateEmpEducations(tblhrEmployeeEducationsVM obj)
        {
            try
            {
                _employeeEducations.UpdateEmpEducations(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEmpEducations(int id)
        {
            try
            {
                _employeeEducations.DeleteEmpEducations(id);
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
