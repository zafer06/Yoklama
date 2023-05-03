using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        readonly ITeacherService _service;
        public TeachersController(ITeacherService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult> GetList()
        {
            var result = await _service.GetListAsync();
            if (result != null)
                return Ok(result);
            return BadRequest();
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result != null)
                return Ok(result);
            return BadRequest();
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            if (result)
                return Ok(result);
            return BadRequest();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> Add([FromBody] Teacher Teacher)
        {
            var result = await _service.AddAsync(Teacher);
            if (result != null)
                return Ok(result);
            return BadRequest();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> AddRange([FromBody] List<Teacher> Teachers)
        {
            var result = await _service.AddRangeAsync(Teachers);
            if (result != null)
                return Ok(result);
            return BadRequest();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> Update([FromBody] Teacher Teacher)
        {
            var result = await _service.UpdateAsync(Teacher);
            if (result != null)
                return Ok(result);
            return BadRequest();
        }
    }
}
