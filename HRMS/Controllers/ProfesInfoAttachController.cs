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
    public class ProfesInfoAttachController : ControllerBase
    {
        ItblProfesInfoAttach _profesInfoAttach;
        public ProfesInfoAttachController(ItblProfesInfoAttach profesInfoAttach)
        {
            _profesInfoAttach = profesInfoAttach;
        }
        #region  ProfesInfoAttach API
        Result<tblProfesInfoAttachVM> _Result = new Result<tblProfesInfoAttachVM>();

        [HttpGet]
        public IActionResult GetProfesInfoAttach()
        {
            Result<List<tblProfesInfoAttachVM>> _Result = new Result<List<tblProfesInfoAttachVM>>();
            try
            {
                _Result.Data = _profesInfoAttach.ProfesInfoAttachList();
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetProfesInfoAttachByid(int id)
        {
            try
            {
                _Result.Data = _profesInfoAttach.GetProfesInfoAttachByid(id);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveProfesInfoAttach(tblProfesInfoAttachVM obj)
        {
            try
            {
                _profesInfoAttach.SaveProfesInfoAttach(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateProfesInfoAttach(tblProfesInfoAttachVM obj)
        {
            try
            {
                _profesInfoAttach.UpdateProfesInfoAttach(obj);
                _Result.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteProfesInfoAttach(int id)
        {
            try
            {
                _profesInfoAttach.DeleteProfesInfoAttach(id);
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
