using HRMS.Helpers;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        IDesignation _designation;
        public DesignationController(IDesignation designation)
        {
            _designation= designation;

        }
        #region  Designation API
        Result<DesignationVM> _Result = new Result<DesignationVM>();
        [HttpGet]
        public IActionResult Getdesignation()
        {
            Result<List<DesignationVM>> _Result = new Result<List<DesignationVM>>();
            try
            {
              _Result.Data=  _designation.DesignationList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetdesignationByid(int id)
        {
            try
            {
              _Result.Data=  _designation.GetDesignationByid(id);
                _Result.IsSuccess = true;
            }


            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult Savedesignation(DesignationVM obj)
        {
            try
            {
                _designation.SaveDesignation(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult Updatedesignation(DesignationVM obj)
        {
            try
            {
                _designation.UpdateDesignation(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {
                _Result.Message = ex.Message;

            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult Deletedeapartment(int id)
        {
            try
            {
                _designation.DeleteDesignation(id);
                _Result.IsSuccess = true;
               
            }
            catch (Exception ex)
            {

              _Result.Message=ex.Message;
            }
            return Ok(_Result);
        }
        #endregion
    }
}
