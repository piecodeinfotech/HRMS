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
    public class PermanentContInfoController : ControllerBase
    {
        IPermanentContInfo _permanentContInfo;
        public PermanentContInfoController(IPermanentContInfo permanentContInfo)
        {
            _permanentContInfo = permanentContInfo;
        }
        #region  PermanentContInfo API
        Result<tblPermanentContInfoVM> _Result = new Result<tblPermanentContInfoVM>();

        [HttpGet]
        public IActionResult Getdepartment()
        {
            Result<List<tblPermanentContInfoVM>> _Result = new Result<List<tblPermanentContInfoVM>>();
            try
            {
                _Result.Data = _permanentContInfo.PermanentContInfoList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetdepartmentByid(int id)
        {
            try
            {
                _Result.Data = _permanentContInfo.GetPermanentContInfoByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult Savedepartment(tblPermanentContInfoVM obj)
        {
            try
            {
                _permanentContInfo.SavePermanentContInfo(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult Updatedepartment(tblPermanentContInfoVM obj)
        {
            try
            {
                _permanentContInfo.UpdatePermanentContInfo(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult Deletedeapartment(int id)
        {
            try
            {
                _permanentContInfo.DeletePermanentContInfo(id);
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
