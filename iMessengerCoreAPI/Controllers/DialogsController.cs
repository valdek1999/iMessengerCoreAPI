using iMessengerCoreAPI.Models;
using iMessengerCoreAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace iMessengerCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DialogsController : ControllerBase
    {
        private IRepository<RGDialogsClients> _contextDialogs;

        public DialogsController(IRepository<RGDialogsClients> contextDialogs)
        {
            _contextDialogs = contextDialogs;
        }

        // GET: api/<DialogsController>
        [HttpGet]
        public ActionResult<IEnumerable<RGDialogsClients>> Get()
        {
            IEnumerable<RGDialogsClients> dialogs = _contextDialogs.All;

            return Ok(dialogs);
        }

        // GET api/<DialogsController>/5
        [HttpGet("dialog/{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // POST api/<DialogsController>
        [HttpPost]
        public void Post([FromBody] List<Guid> clients)
        {
        }

        // PUT api/<DialogsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DialogsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
