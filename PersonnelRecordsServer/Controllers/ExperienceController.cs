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
    public class ExperienceController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public ExperienceController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<ExperienceController>
        [HttpGet]
        public IEnumerable<ExperienceApi> Get()
        {
            return dbContext.Experiences.Select(s => (ExperienceApi)s);
        }

        // GET api/<ExperienceController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExperienceApi>> Get(int id)
        {
            var experience = await dbContext.Experiences.FindAsync(id);
            if (experience == null)
                return NotFound();
            return Ok(experience);
        }

        // POST api/<ExperienceController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] ExperienceApi value)
        {
            var newExperience = (Experience)value;
            dbContext.Experiences.Add(newExperience);
            await dbContext.SaveChangesAsync();
            return Ok(newExperience.Id);
        }

        // PUT api/<ExperienceController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ExperienceApi value)
        {
            var oldExperienc = await dbContext.Experiences.FindAsync(id);
            if (oldExperienc == null)
                return NotFound();
            dbContext.Entry(oldExperienc).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<ExperienceController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldExperienc = await dbContext.Experiences.FindAsync(id);
            if (oldExperienc == null)
                return NotFound();
            dbContext.Experiences.Remove(oldExperienc);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
