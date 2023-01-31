using HRMS.Helpers;
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
    public class CastController : ControllerBase
    {
        ICast _cast;
        public CastController(ICast cast)
        {
            _cast = cast;
        }
        Result<CastVM> _Result = new Result<CastVM>();

        [HttpGet]
        public IActionResult Getcast()
        {
            Result<List<CastVM>> _Result = new Result<List<CastVM>>();
            try
            {
              _Result.Data=  _cast.GetCast();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetcastByid(int id)
        {
            try
            {
             _Result.Data= _cast.CastById(id);
              
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
                
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult Savecast(CastVM obj)
        {
            try
            {
                _cast.CastCreate(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                _Result.Message = ex.Message;

            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult Updatecast(CastVM obj)
        {
            try
            {
              _cast.CastUpdate(obj);
               _Result.IsSuccess= true;
            }
            catch (Exception ex)
            {

               _Result.Message =ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult Deletecast(int id)
        {
            try
            {
                _cast.CastDelete(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

               _Result.Message=ex.Message;
            }
            return Ok(_Result);
        }


    }
}
