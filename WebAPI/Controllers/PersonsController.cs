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
    public class PersonsController : ControllerBase
    {
        readonly IPersonService _service;
        public PersonsController(IPersonService service)
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
        public async Task<ActionResult> Add([FromBody] Person Person)
        {
            var result = await _service.AddAsync(Person);
            if (result != null)
                return Ok(result);
            return BadRequest();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> AddRange([FromBody] List<Person> Persons)
        {
            var result = await _service.AddRangeAsync(Persons);
            if (result != null)
                return Ok(result);
            return BadRequest();
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> Update([FromBody] Person Person)
        {
            var result = await _service.UpdateAsync(Person);
            if (result != null)
                return Ok(result);
            return BadRequest();
        }
    }
}
