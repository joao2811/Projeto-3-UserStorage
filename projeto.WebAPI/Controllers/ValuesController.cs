using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto.WebAPI.Data;

namespace projeto.WebAPI.Controllers
{
    [Route("info/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        public readonly DataContext context;
        public AccountsController(DataContext _context){
            this.context = _context;
        } 
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try{
                return Ok(await context.GameAccounts.ToListAsync());
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status500InternalServerError, "Falha na consulta ao banco: " + ex.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try{
                return Ok(await context.GameAccounts.FirstOrDefaultAsync(x => x.Account_ID == id));
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status500InternalServerError, "Falha na consulta ao banco: " + ex.Message);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
