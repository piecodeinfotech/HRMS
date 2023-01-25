using HRMS.Helpers;
using HRMS.Logic.Interface;
using HRMS.Logic.Service;
using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HRMS.Controllers
{
   
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BloodGroupController : ControllerBase
    {

        private IBloodGroup _bloodGroup;    
        public BloodGroupController(IBloodGroup bloodGroup)
        {
            _bloodGroup = bloodGroup;
        }
        Result<BloodGroupVM> _result = new Result<BloodGroupVM>();

        [HttpGet]
        public IActionResult GetBlood()
        {
            Result<List<BloodGroupVM>> _Result = new Result<List<BloodGroupVM>>();
            try
            {
                _Result.Data = _bloodGroup.GetBloodGroups();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                _Result.Message = ex.Message;
            }
            return Ok(_Result);



        }
        [HttpGet]
        public IActionResult GetBloodByid(int id)
        {
          
            try
            {
                _result.Data = _bloodGroup.BloodGroupById(id);
               _result.IsSuccess=true;

            }
            catch (Exception ex)
            {

                _result.Message = ex.Message;
            }
            return Ok(_result);

        }

        [HttpPost]
        public IActionResult SaveBlood(BloodGroupVM obj)
        {
          
            try
            {
               _bloodGroup.BloodCreate(obj);
              _result.IsSuccess = true;
               
            }
            catch (Exception ex)
            {

                _result.Message = ex.Message;

            }
            return Ok(_result);

           
        }

        [HttpPut]
        public IActionResult UpdateBlood(BloodGroupVM obj)
        {

            try
            {
                _bloodGroup.BloodUpdate(obj);
                _result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                throw;
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult BloodDelete(int id)
        {

            try
            {
                _bloodGroup.BloodDelete(id);
                _result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _result.Message = ex.Message;
            }
            return Ok(_result);
        }



    }
}
