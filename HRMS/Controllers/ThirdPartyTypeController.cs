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
    public class ThirdPartyTypeController : ControllerBase
    {
        IThirdPartyType _thirdPartyType;
        public ThirdPartyTypeController(IThirdPartyType thirdPartyType)
        {
            _thirdPartyType = thirdPartyType;
        }
        #region  ThirdPartyType API
        Result<ThirdPartyTypeVM> _Result = new Result<ThirdPartyTypeVM>();
        [HttpGet]
        public IActionResult GetThirdPartyType()
        {
            Result<List<ThirdPartyTypeVM>> _Result = new Result<List<ThirdPartyTypeVM>>();

            try
            {
                _Result.Data = _thirdPartyType.ThirdPartyTypeList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetThirdPartyTypeByid(int id)
        {
            try
            {
                _Result.Data = _thirdPartyType.GetThirdPartyTypeByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveThirdPartyType(ThirdPartyTypeVM obj)
        {
            try
            {
                _thirdPartyType.SaveThirdPartyType(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateThirdPartyType(ThirdPartyTypeVM obj)
        {
            try
            {
                _thirdPartyType.UpdateThirdPartyType(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteThirdPartyType(int id)
        {
            try
            {
                _thirdPartyType.DeleteThirdPartyType(id);
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
