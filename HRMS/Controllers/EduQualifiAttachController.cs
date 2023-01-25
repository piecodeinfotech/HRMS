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
        IEduQualifiAttach _eduQualifiAttach;
        public EduQualifiAttachController(IEduQualifiAttach eduQualifiAttach)
        {
            _eduQualifiAttach = eduQualifiAttach;   
        }
        #region  EducQualifiAttach API
        Result<EducQualifiAttachVM> _Result = new Result<EducQualifiAttachVM>();
        [HttpGet]
        public IActionResult GetEduQualiAttach()
        {
            Result<List<EducQualifiAttachVM>> _Result = new Result<List<EducQualifiAttachVM>>();

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
        public IActionResult SaveEduQualiAttach(EducQualifiAttachVM obj)
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
        public IActionResult UpdateEduQualiAttach(EducQualifiAttachVM obj)
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
