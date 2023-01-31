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
    public class tblHigherAuthBranchController : ControllerBase
    {
        ItblHigherAuthorityBranch _tblHigherAuthorityBranch;
        public tblHigherAuthBranchController(ItblHigherAuthorityBranch tblHigherAuthorityBranch)
        {
            _tblHigherAuthorityBranch = tblHigherAuthorityBranch;

        }
    

        #region  tblHigherAuthBranch API
        Result<tbl_HigherAuthorityBranchVM> _Result = new Result<tbl_HigherAuthorityBranchVM>();

        [HttpGet]
        public IActionResult GettblHigherAuthBranch()
        {
            Result<List<tbl_HigherAuthorityBranchVM>> _Result = new Result<List<tbl_HigherAuthorityBranchVM>>();
            try
            {
                _Result.Data = _tblHigherAuthorityBranch.tblHigherAuthBranchList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GettblHigherAuthBranchByid(int id)
        {
            try
            {
                _Result.Data = _tblHigherAuthorityBranch.GettblHigherAuthBranchByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SavetblHigherAuthBranch(tbl_HigherAuthorityBranchVM obj)
        {
            try
            {
                _tblHigherAuthorityBranch.SavetblHigherAuthBranch(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdatetblHigherAuthBranch(tbl_HigherAuthorityBranchVM obj)
        {
            try
            {
                _tblHigherAuthorityBranch.UpdatetblHigherAuthBranch(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeletetblHigherAuthBranch(int id)
        {
            try
            {
                _tblHigherAuthorityBranch.DeletetblHigherAuthBranch(id);
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
