using HRMS.Helpers;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        IDistricts _districts;
        public DistrictsController(IDistricts districts)
        {
            _districts=districts;
        }
        #region  Districts API
        Result<DistrictsVM> _Result = new Result<DistrictsVM>();

        [HttpGet]
        public IActionResult Getdistricts()
        {
            Result<List<DistrictsVM>> _Result = new Result<List<DistrictsVM>>();
            try
            {
                _Result.Data = _districts.DistrictsList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetdistrictsByid(int id)
        {
            try
            {
                _Result.Data = _districts.GetDistrictsByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult Savedistricts(DistrictsVM obj)
        {
            try
            {
                _districts.SaveDistricts(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);


        }
        [HttpPut]
        public IActionResult Updatedistricts(DistrictsVM obj)
        {
            try
            {
                _districts.UpdateDistricts(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult Deletedistricts(int id)
        {
            try
            {
                _districts.DeleteDistricts(id);
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
