using HRMS.Helpers;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HigherAuthorityController : ControllerBase
    {
        IHigherAuthority _higherAuthority;
        public HigherAuthorityController(IHigherAuthority higherAuthority)
        {
            _higherAuthority = higherAuthority;
        }
        #region  HigherAuthority API
        Result<HigherAuthorityVM> _Result = new Result<HigherAuthorityVM>();
        [HttpGet]
        public IActionResult GetHigherauthority()
        {
            Result<List<HigherAuthorityVM>> _Result = new Result<List<HigherAuthorityVM>>();
            try
            {
                _Result.Data = _higherAuthority.HigherAuthorityList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetHighAuthorityByid(int id)
        {
            try
            {
                _Result.Data = _higherAuthority.GetHigherAuthorityByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveHighAuthority(HigherAuthorityVM obj)
        {
            try
            {
                _higherAuthority.SaveHigherAuthority(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdatedHighauthority(HigherAuthorityVM obj)
        {
            try
            {
                _higherAuthority.UpdateHigherAuthority(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteHighAuthority(int id)
        {
            try
            {
                _higherAuthority.DeleteHigherAuthority(id);
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

