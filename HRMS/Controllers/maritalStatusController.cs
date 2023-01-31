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
    public class maritalStatusController : ControllerBase
    {
        ItblMaritalStatus _maritalStatus;
        public maritalStatusController(ItblMaritalStatus maritalStatus)
        {
            _maritalStatus = maritalStatus;
        }
        #region  Depaertment API
        Result<tblMaritalStatusVM> _Result = new Result<tblMaritalStatusVM>();

        [HttpGet]
        public IActionResult GetMaritalStatus()
        {
            Result<List<tblMaritalStatusVM>> _Result = new Result<List<tblMaritalStatusVM>>();
            try
            {
                _Result.Data = _maritalStatus.MaritalStatusList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetMaritalStatusByid(int id)
        {
            try
            {
                _Result.Data = _maritalStatus.GetMaritalStatusByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveMaritalStatus(tblMaritalStatusVM obj)
        {
            try
            {
                _maritalStatus.SaveMaritalStatus(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateMaritalStatus(tblMaritalStatusVM obj)
        {
            try
            {
                _maritalStatus.UpdateMaritalStatus(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteMaritalStatus(int id)
        {
            try
            {
                _maritalStatus.DeleteMaritalStatus(id);
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
