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
    public class IdentityTypeController : ControllerBase
    {
        IIdentityType _identityType;

        public IdentityTypeController(IIdentityType identityType)
        {
            _identityType = identityType;
        }
        #region  IdentityType API
        Result<tblIdentityTypeVM> _Result = new Result<tblIdentityTypeVM>();

        [HttpGet]
        public IActionResult GetIdentityType()
        {
            Result<List<tblIdentityTypeVM>> _Result = new Result<List<tblIdentityTypeVM>>();
            try
            {
                _Result.Data = _identityType.IdentityTypeList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetIdentityTypeByid(int id)
        {
            try
            {
                _Result.Data = _identityType.GetIdentityTypeByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveIdentityType(tblIdentityTypeVM obj)
        {
            try
            {
                _identityType.SaveIdentityType(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateIdentityType(tblIdentityTypeVM obj)
        {
            try
            {
                _identityType.UpdateIdentityType(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteIdentityType(int id)
        {
            try
            {
                _identityType.DeleteIdentityType(id);
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
