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
    public class ProductionsController : ControllerBase
    {
        IProductions _productions;
        public ProductionsController(IProductions productions)
        {
            _productions = productions;

        }
        #region  Producations API

        Result<ProductionsVM> _Result = new Result<ProductionsVM>();
        [HttpGet]
        public IActionResult GetProductions()
        {
            Result<List<ProductionsVM>> _Result = new Result<List<ProductionsVM>>();

            try
            {
                _Result.Data = _productions.ProductionsList();
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpGet]
        public IActionResult GetdeProductionsByid(int id)
        {
            try
            {
                _Result.Data = _productions.GetProductionsByid(id);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPost]
        public IActionResult SavedProductions(ProductionsVM obj)
        {
            try
            {
                _productions.SaveProductions(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);

        }
        [HttpPut]
        public IActionResult UpdatedProductions(ProductionsVM obj)
        {
            try
            {
                _productions.UpdateProductions(obj);
                _Result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                _Result.Message = ex.Message;
            }
            return Ok(_Result);
        }
        [HttpDelete]
        public IActionResult DeleteProductions(int id)
        {
            try
            {
                _productions.DeleteProductions(id);
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
