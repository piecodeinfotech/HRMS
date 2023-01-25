using HRMS.Helpers;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Logic.Service;
using HRMS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ThirdPartyController : ControllerBase
    {
        IThirdParty _thirdParty;
        public ThirdPartyController(IThirdParty thirdParty)
        {
            _thirdParty = thirdParty;   
        }

        #region  ThirdParty API
        Result<ThirdPartyVM> _Result = new Result<ThirdPartyVM>();
        [HttpGet]
        public IActionResult GetThirdParty()
        {
            Result<List<ThirdPartyVM>> _Result = new Result<List<ThirdPartyVM>>();

            try
            {
                _Result.Data = _thirdParty.ThirdPartyList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetThirdPartyByid(int id)
        {
            try
            {
                _Result.Data = _thirdParty.GetThirdPartyByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveThirdParty(ThirdPartyVM obj)
        {
            try
            {
                _thirdParty.SaveThirdParty(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateThirdParty(ThirdPartyVM obj)
        {
            try
            {
                _thirdParty.UpdateThirdParty(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteThirdParty(int id)
        {
            try
            {
                _thirdParty.DeleteThirdParty(id);
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
