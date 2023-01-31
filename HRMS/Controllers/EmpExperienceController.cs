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
    public class EmpExperienceController : ControllerBase
    {
        ItblhrEmpExperienceDetails _tblhrEmpExperienceDetails;
        public EmpExperienceController(ItblhrEmpExperienceDetails tblhrEmpExperienceDetails)
        {
            _tblhrEmpExperienceDetails = tblhrEmpExperienceDetails;
        }

        #region  EmpExperienceDetails API
        Result<tblhrEmpExperienceDetailsVM> _Result = new Result<tblhrEmpExperienceDetailsVM>();

        [HttpGet]
        public IActionResult GetEmpExperienceDetails()
        {
            Result<List<tblhrEmpExperienceDetailsVM>> _Result = new Result<List<tblhrEmpExperienceDetailsVM>>();
            try
            {
                _Result.Data = _tblhrEmpExperienceDetails.GetEmpExpeDetails();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpExperienceDetailsByid(int id)
        {
            try
            {
                _Result.Data = _tblhrEmpExperienceDetails.EmpExpeDetailsById(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpExperienceDetails(tblhrEmpExperienceDetailsVM obj)
        {
            try
            {
                _tblhrEmpExperienceDetails.SaveEmpExpeDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateEmpExperienceDetails(tblhrEmpExperienceDetailsVM obj)
        {
            try
            {
                _tblhrEmpExperienceDetails.UpdateEmpExpeDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEmpExperienceDetails(int id)
        {
            try
            {
                _tblhrEmpExperienceDetails.DeleteEmpExpeDetails(id);
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
