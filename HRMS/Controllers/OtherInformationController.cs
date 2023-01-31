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
    public class OtherInformationController : ControllerBase
    {
        IOtherInformation _otherInformation;
        public OtherInformationController(IOtherInformation otherInformation)
        {
            _otherInformation = otherInformation;
        }
        #region  Depaertment API
        Result<tblOtherInformationVM> _Result = new Result<tblOtherInformationVM>();

        [HttpGet]
        public IActionResult GetOtherInfo()
        {
            Result<List<tblOtherInformationVM>> _Result = new Result<List<tblOtherInformationVM>>();
            try
            {
                _Result.Data = _otherInformation.OtherInformationList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetOtherInfoByid(int id)
        {
            try
            {
                _Result.Data = _otherInformation.GetOtherInformationByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveOtherInfo(tblOtherInformationVM obj)
        {
            try
            {
                _otherInformation.SaveOtherInformation(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateOtherInfo(tblOtherInformationVM obj)
        {
            try
            {
                _otherInformation.UpdateOtherInformation(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteOtherInfo(int id)
        {
            try
            {
                _otherInformation.DeleteOtherInformation(id);
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
