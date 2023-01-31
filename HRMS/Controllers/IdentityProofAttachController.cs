using HRMS.Helpers;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace HRMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IdentityProofAttachController : ControllerBase
    {
        IIdentityProofAttach _identityProofAttach;
        public IdentityProofAttachController(IIdentityProofAttach identityProofAttach)
        {
            _identityProofAttach = identityProofAttach;

        }
        #region  IdentityProofAttach API
        Result<tblIdentityProofAttachVM> _Result = new Result<tblIdentityProofAttachVM>();

        [HttpGet]
        public IActionResult GetIdentityProofAttach()
        {
            Result<List<tblIdentityProofAttachVM>> _Result = new Result<List<tblIdentityProofAttachVM>>();
            try
            {
                _Result.Data = _identityProofAttach.IdentityProofAttachList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetIdentityProofAttachByid(int id)
        {
            try
            {
                _Result.Data = _identityProofAttach.GetIdentityProofAttachByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveIdentityProofAttach(tblIdentityProofAttachVM obj)
        {
            try
            {
                _identityProofAttach.SaveIdentityProofAttach(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateIdentityProofAttach(tblIdentityProofAttachVM obj)
        {
            try
            {
                _identityProofAttach.UpdateIdentityProofAttach(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteIdentityProofAttach(int id)
        {
            try
            {
                _identityProofAttach.DeleteIdentityProofAttach(id);
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
