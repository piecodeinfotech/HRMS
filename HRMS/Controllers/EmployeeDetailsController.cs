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
    public class EmployeeDetailsController : ControllerBase
    {
        ItblhrEmployeeDetails _tblhrEmployeeDetails;
        public EmployeeDetailsController(ItblhrEmployeeDetails tblhrEmployeeDetails)
        {
            _tblhrEmployeeDetails = tblhrEmployeeDetails;   
        }
        #region  EmployeeDetails API
        Result<tblhrEmployeeDetailsVM> _Result = new Result<tblhrEmployeeDetailsVM>();

        [HttpGet]
        public IActionResult GethrEmpDetails()
        {
            Result<List<tblhrEmployeeDetailsVM>> _Result = new Result<List<tblhrEmployeeDetailsVM>>();
            try
            {
                _Result.Data = _tblhrEmployeeDetails.EmpDetailsList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GethrEmpDetailsByid(int id)
        {
            try
            {
                _Result.Data = _tblhrEmployeeDetails.GetEmpDetailsByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SavehrEmpDetails(tblhrEmployeeDetailsVM obj)
        {
            try
            {
                _tblhrEmployeeDetails.SaveEmpDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdatehrEmpDetails(tblhrEmployeeDetailsVM obj)
        {
            try
            {
                _tblhrEmployeeDetails.UpdateEmpDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeletehrEmpDetails(int id)
        {
            try
            {
                _tblhrEmployeeDetails.DeleteEmpDetails(id);
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
