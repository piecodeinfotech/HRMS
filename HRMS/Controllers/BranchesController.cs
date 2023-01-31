using HRMS.Helpers;
using HRMS.Logic.Interface;
using HRMS.Logic.Service;
using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace HRMS.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        IBranches _branches;
        public BranchesController(IBranches branches)
        {
            _branches= branches;    
        }

        #region // Branches API
        Result<BranchesVM> _Result = new Result<BranchesVM>();
        [HttpGet]
        public  IActionResult GetBranch()
        {
            Result<List<BranchesVM>> _Result = new Result<List<BranchesVM>>();

            try
            {
               _Result.Data = _branches.Branchlist();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpGet]
        public IActionResult GetbranchByid(int id)
        {
            try
            {
              _Result.Data=  _branches.GetBrancheByid(id);
               
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }


        [HttpPost]
        public IActionResult Savebranch(BranchesVM obj)
        {
            try
            {
               _branches.SaveBranch(obj);
                _Result.IsSuccess = true;
                
            }
            catch (Exception ex)
            {
                _Result.Message = ex.Message;
               
            }
            return Ok(_Result);

        }
        [HttpDelete]
        public IActionResult Deletebranch(int id)
        {
            try
            {
                _branches.DeleteBranch(id);
                _Result.IsSuccess = true;
                
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult Updatebranch(BranchesVM obj)
        {
            try
            {
                _branches.UpdateBranch(obj);
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
