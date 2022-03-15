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
    public class ImpactTypeController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public ImpactTypeController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<ImpactTypeController>
        [HttpGet]
        public IEnumerable<ImpactTypeApi> Get()
        {
            return dbContext.ImpactTypes.Select(s => (ImpactTypeApi)s);
        }

        // GET api/<ImpactTypeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImpactTypeApi>> Get(int id)
        {
            var impactType = await dbContext.ImpactTypes.FindAsync(id);
            if (impactType == null)
                return NotFound();
            return Ok(impactType);
        }

        // POST api/<ImpactTypeController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] ImpactTypeApi value)
        {
            var newImpactType = (ImpactType)value;
            dbContext.ImpactTypes.Add(newImpactType);
            await dbContext.SaveChangesAsync();
            return Ok(newImpactType.Id);
        }

        // PUT api/<ImpactTypeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ImpactTypeApi value)
        {
            var oldImpactType = await dbContext.ImpactTypes.FindAsync(id);
            if (oldImpactType == null)
                return NotFound();
            dbContext.Entry(oldImpactType).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<ImpactTypeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldImpactType = await dbContext.ImpactTypes.FindAsync(id);
            if (oldImpactType == null)
                return NotFound();
            dbContext.ImpactTypes.Remove(oldImpactType);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
