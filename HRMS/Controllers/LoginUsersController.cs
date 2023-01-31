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
    public class LoginUsersController : ControllerBase
    {
        ILoginUsers _loginUsers;
        public LoginUsersController(ILoginUsers loginUsers)
        {
            _loginUsers = loginUsers;
        }
        #region  LoginUsers API
        Result<tblhrLoginUsersVM> _Result = new Result<tblhrLoginUsersVM>();

        [HttpGet]
        public IActionResult GetLoginUsers()
        {
            Result<List<tblhrLoginUsersVM>> _Result = new Result<List<tblhrLoginUsersVM>>();
            try
            {
                _Result.Data = _loginUsers.LoginUsersList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetLoginUsersByid(int id)
        {
            try
            {
                _Result.Data = _loginUsers.GetLoginUsersByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveLoginUsers(tblhrLoginUsersVM obj)
        {
            try
            {
                _loginUsers.SaveLoginUsers(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateLoginUsers(tblhrLoginUsersVM obj)
        {
            try
            {
                _loginUsers.UpdateLoginUsers(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteLoginUsers(int id)
        {
            try
            {
                _loginUsers.DeleteLoginUsers(id);
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
