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
    public class RegionController : ControllerBase
    {
        IRegions _regions;
        public RegionController(IRegions regions)
        {
            _regions = regions;     
        }
        #region  Regions API

        Result<RegionsVM> _Result = new Result<RegionsVM>();

        [HttpGet]
        public IActionResult GetRegions()
        {
            Result<List<RegionsVM>> _Result = new Result<List<RegionsVM>>();
            try
            {
                _Result.Data = _regions.RegionList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetRegionsByid(int id)
        {
            try
            {
                _Result.Data = _regions.GetRegionByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveRegions(RegionsVM obj)
        {
            try
            {
                _regions.SaveRegion(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateRegions(RegionsVM obj)
        {
            try
            {
                _regions.UpdateRegion(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteRegions(int id)
        {
            try
            {
                _regions.DeleteRegion(id);
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
