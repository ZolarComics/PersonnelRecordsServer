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
    public class ArchiveController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public ArchiveController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<ArchiveController>
        [HttpGet]
        public IEnumerable<ArchiveApi> Get()
        {
            return dbContext.Archives.Select(s => (ArchiveApi)s);
        }

        // GET api/<ArchiveController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArchiveApi>> Get(int id)
        {
            var archive = await dbContext.Archives.FindAsync(id);
            if (archive == null)
                return NotFound();
            return Ok(archive);
        }

        // POST api/<ArchiveController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] ArchiveApi value)
        {
            var newArchive = (Archive)value;
            dbContext.Archives.Add(newArchive);
            await dbContext.SaveChangesAsync();
            return Ok(newArchive.Id);
        }

        // PUT api/<ArchiveController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ArchiveApi value)
        {
            var oldArchive = await dbContext.Archives.FindAsync(id);
            if (oldArchive == null)
                return NotFound();
            dbContext.Entry(oldArchive).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<ArchiveController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldArchive = await dbContext.Archives.FindAsync(id);
            if (oldArchive == null)
                return NotFound();
            dbContext.Archives.Remove(oldArchive);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
