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
    public class HigherAuthorityNameController : ControllerBase
    {
        IHigherAuthorityName _higherAuthorityName;

        public HigherAuthorityNameController(IHigherAuthorityName higherAuthorityName)
        {
            _higherAuthorityName = higherAuthorityName;
        }
        #region  HigherAuthorityName API

        Result<HigherAuthorityNameVM> _Result = new Result<HigherAuthorityNameVM>();

        [HttpGet]
        public IActionResult GetHighAuthName()
        {
            Result<List<HigherAuthorityNameVM>> _Result = new Result<List<HigherAuthorityNameVM>>();
            try
            {
                _Result.Data = _higherAuthorityName.HighAuthNameList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetHighAuthNameByid(int id)
        {
            try
            {
                _Result.Data = _higherAuthorityName.GetHighAuthNameByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveHighAuthName(HigherAuthorityNameVM obj)
        {
            try
            {
                _higherAuthorityName.SaveHighAuthName(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateHighAuthorityName(HigherAuthorityNameVM obj)
        {
            try
            {
                _higherAuthorityName.UpdateHighAuthName(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteHighAuthName(int id)
        {
            try
            {
                _higherAuthorityName.DeleteHighAuthName(id);
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

