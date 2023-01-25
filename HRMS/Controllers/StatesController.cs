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
    public class StatesController : ControllerBase
    {
        IStates _states;
        public StatesController(IStates states)
        {
            _states = states;   
        }

        #region  States API
        Result<StatesVM> _Result = new Result<StatesVM>();
        [HttpGet]
        public IActionResult GetState()
        {
            Result<List<StatesVM>> _Result = new Result<List<StatesVM>>();

            try
            {
                _Result.Data = _states.StatesList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetStateByid(int id)
        {
            try
            {
                _Result.Data = _states.GetStatesByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveState(StatesVM obj)
        {
            try
            {
                _states.SaveStates(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpPut]
        public IActionResult UpdateState(StatesVM obj)
        {
            try
            {
              _states.UpdateStates(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteState(int id)
        {
            try
            {
                _states.DeleteStates(id);
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
