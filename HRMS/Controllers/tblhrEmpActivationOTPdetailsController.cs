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
    public class tblhrEmpActivationotpdetailsController : ControllerBase
    {
        ItblhrEmpActivationOTPdetails _tblhrEmpActivationOTPdetails;

        public tblhrEmpActivationotpdetailsController(ItblhrEmpActivationOTPdetails itblhrEmpActivationOTPdetails)
        {
            _tblhrEmpActivationOTPdetails = itblhrEmpActivationOTPdetails;
        }
        #region  EmpActivationotpdetails API
        Result<tblhrEmpActivationotpdetailsVM> _Result = new Result<tblhrEmpActivationotpdetailsVM>();

        [HttpGet]
        public IActionResult GetEmpActiOtpdetails()
        {
            Result<List<tblhrEmpActivationotpdetailsVM>> _Result = new Result<List<tblhrEmpActivationotpdetailsVM>>();
            try
            {
                _Result.Data = _tblhrEmpActivationOTPdetails.EmpActiOtpdetailsList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpActiOtpdetailsByid(int id)
        {
            try
            {
                _Result.Data = _tblhrEmpActivationOTPdetails.GetEmpActiOtpdetailsByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpActiOtpdetails(tblhrEmpActivationotpdetailsVM obj)
        {
            try
            {
                _tblhrEmpActivationOTPdetails.SaveEmpActiOtpdetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateEmpActiOtpdetails(tblhrEmpActivationotpdetailsVM obj)
        {
            try
            {
                _tblhrEmpActivationOTPdetails.UpdateEmpActiOtpdetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEmpActiOtpdetails(int id)
        {
            try
            {
                _tblhrEmpActivationOTPdetails.DeleteEmpActiOtpdetails(id);
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
