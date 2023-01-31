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
    public class tblUserTypeController : ControllerBase
    {
        ItbluserType _tbluserType;
        public tblUserTypeController(ItbluserType tbluserType)
        {
            _tbluserType = tbluserType;
        }
        #region  TbluserType API
        Result<tblUserTypeVM> _Result = new Result<tblUserTypeVM>();

        [HttpGet]
        public IActionResult GettbluserType()
        {
            Result<List<tblUserTypeVM>> _Result = new Result<List<tblUserTypeVM>>();
            try
            {
                _Result.Data = _tbluserType.tblUserTypeList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GettbluserTypeByid(int id)
        {
            try
            {
                _Result.Data = _tbluserType.GettblUserTypeByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SavetbluserType(tblUserTypeVM obj)
        {
            try
            {
                _tbluserType.SavetblUserType(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdatetbluserType(tblUserTypeVM obj)
        {
            try
            {
                _tbluserType.UpdatetblUserType(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeletetbluserType(int id)
        {
            try
            {
                _tbluserType.DeletetblUserType(id);
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
