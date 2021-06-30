using Core.CommonTypes.Business;
using Core.CommonTypes.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Core.CommonTypes.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController<TEntity> : ControllerBase
        where TEntity : BaseEntity, IEntity, new()
    {
        private readonly IBaseServiceRepository<TEntity> _businessLayer;
        public BaseApiController(IBaseServiceRepository<TEntity> businessLayer)
        {
            _businessLayer = businessLayer;
        }

        [HttpPost("add")]
        public virtual IActionResult Add(TEntity entity)
        {
            var result = _businessLayer.Add(entity);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public virtual IActionResult Update(TEntity entity)
        {
            var result = _businessLayer.Update(entity);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public virtual IActionResult Delete(TEntity entity)
        {
            var result = _businessLayer.Delete(entity);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            var result = _businessLayer.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _businessLayer.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
