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
    public class ProfessionalInformationController : ControllerBase
    {
        IProfessionalInformation _profInformation;
        public ProfessionalInformationController(IProfessionalInformation profInformation)
        {
            _profInformation = profInformation;
           
        }

        #region  ProfessionalInformation API

        Result<ProfessionalInformationVM> _Result = new Result<ProfessionalInformationVM>();
        [HttpGet]
        public IActionResult GetProfeInfo()
        {
            Result<List<ProfessionalInformationVM>> _Result = new Result<List<ProfessionalInformationVM>>();
            try
            {
               _Result.Data= _profInformation.ProInfoList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpGet]
        public IActionResult GetProfeInfoByid(int id)
        {
            try
            {
              _Result.Data=  _profInformation.GetProInfoByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveProfeInfo(ProfessionalInformationVM obj)
        {
            try
            {
                _profInformation.SaveProInfo(   obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateProfeInfo(ProfessionalInformationVM obj)
        {
            try
            {
                _profInformation.UpdateProInfo(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteProfeInfo(int id)
        {
            try
            {
                _profInformation.DeleteProInfo(id);
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
