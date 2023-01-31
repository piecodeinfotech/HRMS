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
    public class IdentityProofController : ControllerBase
    {
        IIdentityProof _identityProof;
        public IdentityProofController(IIdentityProof identityProof)
        {
            _identityProof = identityProof;
        }
        #region  IdentityProof API
        Result<tblIdentityProofVM> _Result = new Result<tblIdentityProofVM>();

        [HttpGet]
        public IActionResult GetIdentityProof()
        {
            Result<List<tblIdentityProofVM>> _Result = new Result<List<tblIdentityProofVM>>();
            try
            {
                _Result.Data = _identityProof.IdentityProofList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetIdentityProofByid(int id)
        {
            try
            {
                _Result.Data = _identityProof.GetIdentityProofByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveIdentityProof(tblIdentityProofVM obj)
        {
            try
            {
                _identityProof.SaveIdentityProof(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateIdentityProof(tblIdentityProofVM obj)
        {
            try
            {
                _identityProof.UpdateIdentityProof(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteIdentityProof(int id)
        {
            try
            {
                _identityProof.DeleteIdentityProof(id);
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
