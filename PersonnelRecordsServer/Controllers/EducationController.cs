using Microsoft.AspNetCore.Mvc;
using ModelApi;
using PersonnelRecordsServer.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonnelRecordsServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public EducationController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<EducationController>
        [HttpGet]
        public IEnumerable<EducationApi> Get()
        {
            return dbContext.Educations.Select(s => (EducationApi)s);
        }

        // GET api/<EducationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EducationApi>> Get(int id)
        {
            var education = await dbContext.Educations.FindAsync(id);
            if (education == null)
                return NotFound();
            return Ok(education);
        }

        // POST api/<EducationController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] EducationApi value)
        {
            var newEducation = (Education)value;
            dbContext.Educations.Add(newEducation);
            await dbContext.SaveChangesAsync();
            return Ok(newEducation.Id);
        }

        // PUT api/<EducationController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EducationApi value)
        {
            var oldEducation = await dbContext.Educations.FindAsync(id);
            if (oldEducation == null)
                return NotFound();
            dbContext.Entry(oldEducation).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<EducationController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldEducation = await dbContext.Educations.FindAsync(id);
            if (oldEducation == null)
                return NotFound();
            dbContext.Educations.Remove(oldEducation);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
