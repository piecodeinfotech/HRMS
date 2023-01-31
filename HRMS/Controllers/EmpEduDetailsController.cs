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
    public class EmpEduDetailsController : ControllerBase
    {
        ItblhrEmployeeEducationDetails _tblhrEmployeeEducationDetails;
        public EmpEduDetailsController(ItblhrEmployeeEducationDetails tblhrEmployeeEducationDetails)
        {
            _tblhrEmployeeEducationDetails = tblhrEmployeeEducationDetails; 
        }

        #region  TblhrEmpEduDetails API
        Result<tblhrEmployeeEducationDetailsVM> _Result = new Result<tblhrEmployeeEducationDetailsVM>();

        [HttpGet]
        public IActionResult GetEmpEduDetails()
        {
            Result<List<tblhrEmployeeEducationDetailsVM>> _Result = new Result<List<tblhrEmployeeEducationDetailsVM>>();
            try
            {
                _Result.Data = _tblhrEmployeeEducationDetails.EmpEduDetailsList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpEduDetailsByid(int id)
        {
            try
            {
                _Result.Data = _tblhrEmployeeEducationDetails.GetEmpEduDetailsByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpEduDetails(tblhrEmployeeEducationDetailsVM obj)
        {
            try
            {
                _tblhrEmployeeEducationDetails.SaveEmpEduDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateEmpEduDetails(tblhrEmployeeEducationDetailsVM obj)
        {
            try
            {
                _tblhrEmployeeEducationDetails.UpdateEmpEduDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEmpEduDetails(int id)
        {
            try
            {
                _tblhrEmployeeEducationDetails.DeleteEmpEduDetails(id);
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
