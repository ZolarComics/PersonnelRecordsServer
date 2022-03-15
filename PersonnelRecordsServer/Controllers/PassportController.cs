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
    public class PassportController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public PassportController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<PassportController>
        [HttpGet]
        public IEnumerable<PassportApi> Get()
        {
            return dbContext.Passports.Select(s => (PassportApi)s);
        }

        // GET api/<PassportController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PassportApi>> Get(int id)
        {
            var passport = await dbContext.Passports.FindAsync(id);
            if (passport == null)
                return NotFound();
            return Ok(passport);
        }

        // POST api/<PassportController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] PassportApi value)
        {
            var newPassport = (Passport)value;
            dbContext.Passports.Add(newPassport);
            await dbContext.SaveChangesAsync();
            return Ok(newPassport.Id);
        }

        // PUT api/<PassportController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PassportApi value)
        {
            var oldPassport = await dbContext.Passports.FindAsync(id);
            if (oldPassport == null)
                return NotFound();
            dbContext.Entry(oldPassport).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<PassportController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldPassport = await dbContext.Passports.FindAsync(id);
            if (oldPassport == null)
                return NotFound();
            dbContext.Passports.Remove(oldPassport);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
