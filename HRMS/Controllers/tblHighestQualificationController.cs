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
    public class tblHighestQualificationController : ControllerBase
    {
        Itbl_HighestQualification _tblhighestQualification;
        public tblHighestQualificationController(Itbl_HighestQualification tblhighestQualification)
        {
            _tblhighestQualification = tblhighestQualification;
        }
        #region  HighestQualification API
        Result<tbl_HighestQualificationVM> _Result = new Result<tbl_HighestQualificationVM>();

        [HttpGet]
        public IActionResult GetHighQualifi()
        {
            Result<List<tbl_HighestQualificationVM>> _Result = new Result<List<tbl_HighestQualificationVM>>();
            try
            {
                _Result.Data = _tblhighestQualification.Get_tblHighQualifiList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetHighQualifiByid(int id)
        {
            try
            {
                _Result.Data = _tblhighestQualification.Get_tblHighQualifiById(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveHighQualifi(tbl_HighestQualificationVM obj)
        {
            try
            {
                _tblhighestQualification.Save_tblHighQualifi(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateHighQualifi(tbl_HighestQualificationVM obj)
        {
            try
            {
                _tblhighestQualification.Update_tblHighQualifi(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteHighQualifi(int id)
        {
            try
            {
                _tblhighestQualification.Delete_tblHighQualifi(id);
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
