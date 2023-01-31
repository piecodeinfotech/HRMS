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
    public class UserTypeController : ControllerBase
    {
        IUserType _userType;
        public UserTypeController(IUserType userType)
        {
            _userType = userType;  
        }
        #region  UserType API
        Result<UserTypeVM> _Result = new Result<UserTypeVM>();
        [HttpGet]
        public IActionResult GetUserType()
        {
            Result<List<UserTypeVM>> _Result = new Result<List<UserTypeVM>>();

            try
            {
                _Result.Data = _userType.UserTypeList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetUserTypeByid(int id)
        {
            try
            {
                _Result.Data = _userType.GetUserTypeByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveUserType(UserTypeVM obj)
        {
            try
            {
                _userType.SaveUserType(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateUserType(UserTypeVM obj)
        {
            try
            {
                _userType.UpdateUserType(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteUserType(int id)
        {
            try
            {
                _userType.DeleteUserType(id);
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
