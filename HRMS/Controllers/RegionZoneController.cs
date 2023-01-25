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
    public class RegionZoneController : ControllerBase
    {

        IRegionZone _RegionZone;
        public RegionZoneController(IRegionZone regionZone)
        {
            _RegionZone = regionZone;   
        }
        #region  RegionZone API

        Result<RegionZoneVM> _Result = new Result<RegionZoneVM>();
        [HttpGet]
        public IActionResult GetRegZone()
        {
            Result<List<RegionZoneVM>> _Result = new Result<List<RegionZoneVM>>();
            try
            {
             _Result.Data=   _RegionZone.RegionZoneList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetRegZoneByid(int id)
        {
            try
            {
                _Result.Data = _RegionZone.GetRegionZoneByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveRegZone(RegionZoneVM obj)
        {
            try
            {
                _RegionZone.SaveRegionZone(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);


        }
        [HttpPut]
        public IActionResult UpdateRegZone(RegionZoneVM obj)
        {
            try
            {
                _RegionZone.UpdateRegionZone(obj);
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
                _RegionZone.DeleteRegionZone(id);
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
