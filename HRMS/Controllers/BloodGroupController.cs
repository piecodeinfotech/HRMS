using HRMS.Logic.Interface;
using HRMS.Logic.Service;
using HRMS.Model;
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

        [HttpGet]
        public IActionResult GetBlood()
        {
            try
            {
                var data = _bloodGroup.GetBloodGroups();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }


        }
        [HttpGet]
        public IActionResult GetBloodByid(int id)
        {
            try
            {
                var record = _bloodGroup.BloodGroupById(id);
                return Ok(record);

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpPost]
        public IActionResult SaveBlood(BloodGroupVM obj)
        {
            try
            {
                _bloodGroup.BloodCreate(obj);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }

           
        }

        [HttpPut]
        public IActionResult UpdateBlood(BloodGroupVM obj)
        {
            try
            {
                _bloodGroup.BloodUpdate(obj);

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
            }
            catch (Exception ex)
            {

                throw;
            }
            return Ok();
        }



    }
}
