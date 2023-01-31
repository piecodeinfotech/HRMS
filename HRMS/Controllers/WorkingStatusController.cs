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
    public class WorkingStatusController : ControllerBase
    {
        IWorkingStatus _workingStatus;
        public WorkingStatusController(IWorkingStatus workingStatus)
        {
            _workingStatus =workingStatus;
        }
        #region  WorkingStatus API
        Result<WorkingStatusVM> _Result = new Result<WorkingStatusVM>();
        [HttpGet]
        public IActionResult GetWorkStatus()
        {
            Result<List<WorkingStatusVM>> _Result = new Result<List<WorkingStatusVM>>();

            try
            {
                _Result.Data = _workingStatus.WorkingStatusList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetWorkStatusByid(int id)
        {
            try
            {
                _Result.Data = _workingStatus.GetWorkingStatusByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveWorkStatus(WorkingStatusVM obj)
        {
            try
            {
                _workingStatus.SaveWorkingStatus(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateWorkStatus(WorkingStatusVM obj)
        {
            try
            {
                _workingStatus.UpdateWorkingStatus(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteWorkStatus(int id)
        {
            try
            {
                _workingStatus.DeleteWorkingStatus(id);
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
