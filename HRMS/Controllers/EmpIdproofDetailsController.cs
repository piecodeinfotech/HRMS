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
    public class EmpIdproofDetailsController : ControllerBase
    {
        IEmpIdProofDetails _empIdProofDetails;
        public EmpIdproofDetailsController(IEmpIdProofDetails empIdProofDetails)
        {
            _empIdProofDetails = empIdProofDetails;
        }
        #region  EmpIdproofDetails API
        Result<tblhrEmpIdproofDetailsVM> _Result = new Result<tblhrEmpIdproofDetailsVM>();

        [HttpGet]
        public IActionResult GetEmpIdproofDetails()
        {
            Result<List<tblhrEmpIdproofDetailsVM>> _Result = new Result<List<tblhrEmpIdproofDetailsVM>>();
            try
            {
                _Result.Data = _empIdProofDetails.EmpIdproofDetailsList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetEmpIdproofDetailsByid(int id)
        {
            try
            {
                _Result.Data = _empIdProofDetails.GetEmpIdproofDetailsByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveEmpIdproofDetails(tblhrEmpIdproofDetailsVM obj)
        {
            try
            {
                _empIdProofDetails.SaveEmpIdproofDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateEmpIdproofDetails(tblhrEmpIdproofDetailsVM obj)
        {
            try
            {
                _empIdProofDetails.UpdateEmpIdproofDetails(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteEmpIdproofDetails(int id)
        {
            try
            {
                _empIdProofDetails.DeleteEmpIdproofDetails(id);
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
