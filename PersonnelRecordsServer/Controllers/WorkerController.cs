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
    public class WorkerController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public WorkerController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<WorkerController>
        [HttpGet]
        public IEnumerable<WorkerApi> Get()
        {
            return dbContext.Workers.Select(s => (WorkerApi)s);
        }

        // GET api/<WorkerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkerApi>> Get(int id)
        {
            var worker = await dbContext.Workers.FindAsync(id);
            if (worker == null)
                return NotFound();
            return Ok(worker);
        }

        // POST api/<WorkerController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] WorkerApi value)
        {
            var newWorker = (Worker)value;
            dbContext.Workers.Add(newWorker);
            await dbContext.SaveChangesAsync();
            return Ok(newWorker.Id);
        }

        // PUT api/<WorkerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] WorkerApi value)
        {
            var oldWorker = await dbContext.Workers.FindAsync(id);
            if (oldWorker == null)
                return NotFound();
            dbContext.Entry(oldWorker).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<WorkerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldWorker = await dbContext.Workers.FindAsync(id);
            if (oldWorker == null)
                return NotFound();
            dbContext.Workers.Remove(oldWorker);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
