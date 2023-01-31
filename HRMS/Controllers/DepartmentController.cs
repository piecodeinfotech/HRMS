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
    public class DepartmentController : ControllerBase
    {
        IDepartment _department;
        public DepartmentController(IDepartment department)
        {
            _department = department;
        }
#region  Depaertment API
        Result<DepartmentVM> _Result = new Result<DepartmentVM>();

        [HttpGet]
        public IActionResult Getdepartment()
        {
            Result<List<DepartmentVM>> _Result = new Result<List<DepartmentVM>>();
            try
            {
              _Result.Data =  _department.DepartmentList();
                _Result.IsSuccess = true;
               
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetdepartmentByid(int id)
        {
            try
            {
              _Result.Data=  _department.GetDeapartmentByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex) 
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult Savedepartment(DepartmentVM obj)
        {
            try
            {
                _department.SaveDeapartment(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult Updatedepartment(DepartmentVM obj)
        {
            try
            {
                _department.UpdateDeapartment(obj);
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
                _department.DeleteDeapartment(id);
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
