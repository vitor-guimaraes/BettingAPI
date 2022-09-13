using BettingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BettingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionshipController : ControllerBase
    {
        // GET api/<ChampionshipController>/5
        [HttpGet("{championships}")]
        public IEnumerable<Championships> Get()
        {
            return null;
        }

        // POST api/<ChampionshipController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChampionshipController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChampionshipController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
