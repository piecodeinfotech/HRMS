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
    public class EduQualifiAttachController : ControllerBase
    {
        ItblEduQualifiAttach _eduQualifiAttach;
        public EduQualifiAttachController(ItblEduQualifiAttach eduQualifiAttach)
        {
            _eduQualifiAttach = eduQualifiAttach;   
        }
        #region  EducQualifiAttach API
        Result<tblEducQualifiAttachVM> _Result = new Result<tblEducQualifiAttachVM>();
        [HttpGet]
        public IActionResult GetEduQualiAttach()
        {
            Result<List<tblEducQualifiAttachVM>> _Result = new Result<List<tblEducQualifiAttachVM>>();

            try
            {
                _Result.Data = _eduQualifiAttach.EduQualifiAttachList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEduQualiAttachByid(int id)
        {
            try
            {
                _Result.Data = _eduQualifiAttach.GetEduQualifiAttachByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEduQualiAttach(tblEducQualifiAttachVM obj)
        {
            try
            {
                _eduQualifiAttach.SaveEduQualifiAttach(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateEduQualiAttach(tblEducQualifiAttachVM obj)
        {
            try
            {
                _eduQualifiAttach.UpdateEduQualifiAttach(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEduQualiAttach(int id)
        {
            try
            {
                _eduQualifiAttach.DeleteEduQualifiAttach(id);
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
