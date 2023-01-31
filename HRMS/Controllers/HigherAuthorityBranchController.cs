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
    public class HigherAuthorityBranchController : ControllerBase
    {
        IHigherAuthorityBranch _higherAuthorityBranch;
        public HigherAuthorityBranchController(IHigherAuthorityBranch higherAuthorityBranch)
        {
            _higherAuthorityBranch = higherAuthorityBranch; 
        }
        #region  HigherAuthorityBranch API
        Result<HigherAuthorityBranchVM> _Result = new Result<HigherAuthorityBranchVM>();
        [HttpGet]
        public IActionResult GetHighAuthorityBranch()
        {
            Result<List<HigherAuthorityBranchVM>> _Result = new Result<List<HigherAuthorityBranchVM>>();
            try
            {
             _Result.Data=   _higherAuthorityBranch.HigherAuthorityBranchList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetHighAuthorityBranchByid(int id)
        {
            try
            {
              _Result.Data=  _higherAuthorityBranch.GetHighAuthorityBranchByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveHighAuthorityBranch(HigherAuthorityBranchVM obj)
        {
            try
            {
                _higherAuthorityBranch.SaveHigherAuthorityBranch(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateHighAuthorityBranch(HigherAuthorityBranchVM obj)
        {
            try
            {
                _higherAuthorityBranch.UpdateHighAuthorityBranch(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteHighAuthorityBranch(int id)
        {
            try
            {
                _higherAuthorityBranch.DeleteHighAuthorityBranch(id);
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
