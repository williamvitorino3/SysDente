using SysDente.Entities;
using SysDente.Services;
using SysDente.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysDente.Controllers.Impl
{
    public abstract class ControllerBase<T> : Controller, IControllerBase<T> where T : class, IEntity, new()
    {
        private readonly IServiceBase<T> _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public ControllerBase(IServiceBase<T> service)
        {
            this._service = service;
        }

       [HttpGet]
       public virtual IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
       
      
        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            var result = _service.Get(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]

        public virtual IActionResult Create([FromBody]T newObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = _service.Create(newObject);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return CreatedAtRoute("default", new { id = newObject.Id }, newObject);

        }
       

      
        [HttpPut("{id}")]
        public virtual IActionResult Update(int id, [FromBody]T newObject)
        {
            var result = _service.Get(id);
            //newObject.Id = id;
            if (result == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                result = _service.Update(newObject, id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            var result = _service.Get(id);
            if (result == null)
            {
                return NotFound();
            }
            try
            {
                _service.Delete(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok();
        }
    }
}