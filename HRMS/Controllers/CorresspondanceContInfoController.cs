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
    public class CorresspondanceContInfoController : ControllerBase
    {
        ICorresspondanceContInfo _corresspondanceContInfo;
        public CorresspondanceContInfoController(ICorresspondanceContInfo corresspondanceContInfo)
        {
            _corresspondanceContInfo = corresspondanceContInfo; 
        }
        #region  CorresspondanceContInfo API

        Result<tblCorresspondanceContInfoVM> _Result = new Result<tblCorresspondanceContInfoVM>();

        [HttpGet]
        public IActionResult GetCorrContInfo()
        {
            Result<List<tblCorresspondanceContInfoVM>> _Result = new Result<List<tblCorresspondanceContInfoVM>>();

            try
            {
                _Result.Data = _corresspondanceContInfo.CorreContInfoList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetCorrContInfoByid(int id)
        {
            try
            {
                _Result.Data = _corresspondanceContInfo.GetCorreContInfoByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveCorrContInfo(tblCorresspondanceContInfoVM obj)
        {
            try
            {
                _corresspondanceContInfo.SaveCorreContInfo(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateCorrContInfo(tblCorresspondanceContInfoVM obj)
        {
            try
            {
                _corresspondanceContInfo.UpdateCorreContInfo(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteCorrContInfo(int id)
        {
            try
            {
                _corresspondanceContInfo.DeleteCorreContInfo(id);
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
