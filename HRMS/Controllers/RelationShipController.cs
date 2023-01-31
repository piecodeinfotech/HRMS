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
    public class RelationShipController : ControllerBase
    {
        IRelationship _relationship;
        public RelationShipController(IRelationship relationship)
        {
            _relationship = relationship;       
        }
        #region  RelationShip API
        Result<RelationshipVM> _Result = new Result<RelationshipVM>();
        [HttpGet]
        public IActionResult GetRelationship()
        {
        
            Result<List<RelationshipVM>> _Result = new Result<List<RelationshipVM>>();
            try
            {
                _Result.Data = _relationship.RelationshipList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetRelationshipByid(int id)
        {
            try
            {
                _Result.Data = _relationship.GetRelationshipByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SaveRelationship(RelationshipVM obj)
        {
            try
            {
                _relationship.SaveRelationship(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdateRelationship(RelationshipVM obj)
        {
            try
            {
                _relationship.UpdateRelationship(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteRelationship(int id)
        {
            try
            {
                _relationship.DeleteRelationship(id);
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
