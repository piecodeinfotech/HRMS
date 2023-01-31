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
    public class EmpFamilyDetailsController : ControllerBase
    {
        IEmpFamilydetails _empFamilydetails;
        public EmpFamilyDetailsController(IEmpFamilydetails empFamilydetails)
        {
            _empFamilydetails = empFamilydetails;
        }
        #region  EmpFamilydetails API
        Result<tblhrEmployeeFamilyDetailsVM> _Result = new Result<tblhrEmployeeFamilyDetailsVM>();

        [HttpGet]
        public IActionResult GetEmpFamilyDetails()
        {
            Result<List<tblhrEmployeeFamilyDetailsVM>> _Result = new Result<List<tblhrEmployeeFamilyDetailsVM>>();
            try
            {
                _Result.Data = _empFamilydetails.EmpFamilyDetailsList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpFamilyDetailsByid(int id)
        {
            try
            {
                _Result.Data = _empFamilydetails.GetEmpFamilyDetailsByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpFamilyDetails(tblhrEmployeeFamilyDetailsVM obj)
        {
            try
            {
                _empFamilydetails.SaveEmpFamilyDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateEmpFamilyDetails(tblhrEmployeeFamilyDetailsVM obj)
        {
            try
            {
                _empFamilydetails.UpdateEmpFamilyDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEmpFamilyDetails(int id)
        {
            try
            {
                _empFamilydetails.DeleteEmpFamilyDetails(id);
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
