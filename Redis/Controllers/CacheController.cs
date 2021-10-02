using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Redis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        private readonly IDatabase _databasae;

        public CacheController(IDatabase databasae)
        {
            _databasae = databasae;
        }
        // GET: api/<CacheController>
        [HttpGet]
        public string Get(string key)
        {
            return _databasae.StringGet(key);
        }

        // POST api/<CacheController>
        [HttpPost]
        public void Post([FromBody] KeyValuePair<string,string> keyValue)
        {
            _databasae.StringSet(keyValue.Key, keyValue.Value);
        }

    }
}
