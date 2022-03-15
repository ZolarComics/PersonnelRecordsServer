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
    public class StaffingController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public StaffingController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<StaffingController>
        [HttpGet]
        public IEnumerable<StaffingApi> Get()
        {
            return dbContext.Staffings.Select(s => (StaffingApi)s);
        }

        // GET api/<StaffingController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StaffingApi>> Get(int id)
        {
            var staffing = await dbContext.Staffings.FindAsync(id);
            if (staffing == null)
                return NotFound();
            return Ok(staffing);
        }

        // POST api/<StaffingController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] StaffingApi value)
        {
            var newStaffing = (Staffing)value;
            dbContext.Staffings.Add(newStaffing);
            await dbContext.SaveChangesAsync();
            return Ok(newStaffing.Id);
        }

        // PUT api/<StaffingController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] StaffingApi value)
        {
            var oldStaffing = await dbContext.Staffings.FindAsync(id);
            if (oldStaffing == null)
                return NotFound();
            dbContext.Entry(oldStaffing).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        // DELETE api/<StaffingController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldStaffing = await dbContext.Staffings.FindAsync(id);
            if (oldStaffing == null)
                return NotFound();
            dbContext.Staffings.Remove(oldStaffing);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
