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
    public class EmpNomineeDetailsController : ControllerBase
    {
        IEmpNomineeDetails _empNomineeDetails;
        public EmpNomineeDetailsController(IEmpNomineeDetails empNomineeDetails)
        {
            _empNomineeDetails = empNomineeDetails;
        }
        #region  EmpNomineeDetails API
        Result<tblhrEmpNomineeDetailsVM> _Result = new Result<tblhrEmpNomineeDetailsVM>();

        [HttpGet]
        public IActionResult GetEmpNomineeDetails()
        {
            Result<List<tblhrEmpNomineeDetailsVM>> _Result = new Result<List<tblhrEmpNomineeDetailsVM>>();
            try
            {
                _Result.Data = _empNomineeDetails.EmpNomineeDetailsList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpNomineeDetailsByid(int id)
        {
            try
            {
                _Result.Data = _empNomineeDetails.GetEmpNomineeDetailsByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpNomineeDetails(tblhrEmpNomineeDetailsVM obj)
        {
            try
            {
                _empNomineeDetails.SaveEmpNomineeDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateEmpNomineeDetails(tblhrEmpNomineeDetailsVM obj)
        {
            try
            {
                _empNomineeDetails.UpdateEmpNomineeDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEmpNomineeDetails(int id)
        {
            try
            {
                _empNomineeDetails.DeleteEmpNomineeDetails(id);
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
