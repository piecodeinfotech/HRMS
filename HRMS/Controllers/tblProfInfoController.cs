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
    public class tblProfInfoController : ControllerBase
    {
        ItblProfessionalInformation _professionalInformation;
        public tblProfInfoController(ItblProfessionalInformation professionalInformation)
        {
            _professionalInformation = professionalInformation;
        }
        #region  ProfInfo API
        Result<tblProfessionalInformationVM> _Result = new Result<tblProfessionalInformationVM>();

        [HttpGet]
        public IActionResult GetProfInfo()
        {
            Result<List<tblProfessionalInformationVM>> _Result = new Result<List<tblProfessionalInformationVM>>();
            try
            {
                _Result.Data = _professionalInformation.ProfInfoList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetProfInfoByid(int id)
        {
            try
            {
                _Result.Data = _professionalInformation.GetProfInfoByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveProfInfo(tblProfessionalInformationVM obj)
        {
            try
            {
                _professionalInformation.SaveProfInfo(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateProfInfo(tblProfessionalInformationVM obj)
        {
            try
            {
                _professionalInformation.UpdateProfInfo(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteProfInfo(int id)
        {
            try
            {
                _professionalInformation.DeleteProfInfo(id);
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
