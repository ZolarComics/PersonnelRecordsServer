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
    public class CompanyController : ControllerBase
    {
        private readonly PersonnelRecordsContext dbContext;

        public CompanyController(PersonnelRecordsContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public IEnumerable<CompanyApi> Get()
        {
            return dbContext.Companies.Select(s => (CompanyApi)s);
        }


        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyApi>> Get(int id)
        {
            var company = await dbContext.Companies.FindAsync(id);
            if (company == null)
                return NotFound();
            return Ok(company);
        }


        // POST api/<CompanyController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] CompanyApi value)
        {
            var newCompany = (Company)value;
            dbContext.Companies.Add(newCompany);
            await dbContext.SaveChangesAsync();
            return Ok(newCompany.Id);
        }


        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CompanyApi value)
        {
            var oldCompany = await dbContext.Companies.FindAsync(id);
            if (oldCompany == null)
                return NotFound();
            dbContext.Entry(oldCompany).CurrentValues.SetValues(value);
            await dbContext.SaveChangesAsync();
            return Ok();
        }


        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var oldCompany = await dbContext.Companies.FindAsync(id);
            if (oldCompany == null)
                return NotFound();
            dbContext.Companies.Remove(oldCompany);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
