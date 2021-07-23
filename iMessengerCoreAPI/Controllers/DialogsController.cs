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
    [Route("api/dialogs")]
    [ApiController]
    public class DialogsController : ControllerBase
    {
        private IRepository<RGDialogsClients> _contextDialogs;

        public DialogsController(IRepository<RGDialogsClients> contextDialogs)
        {
            _contextDialogs = contextDialogs;
        }

        /// <summary>
        /// Позволяет получить такой GUID диалога, в котором 
        /// есть все переданные клиенты.
        /// Если нет такого диалога -> возращается пустой GUID.
        /// </summary>
        /// <param name="clients">Список идентификаторов - GUID клиентов</param>
        /// <returns>GUID идентификатор диалога</returns>
        [HttpGet("dialogID")]
        public ActionResult<Guid> GetDialogID([FromQuery] List<Guid> clients)
        {
            return Ok(_contextDialogs.FindDialogID(clients));
        }

        /// <summary>
        /// Позволяет получить список всех диалогов cвязанных с клиентами
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<RGDialogsClients>> GetAll()
        {
            IEnumerable<RGDialogsClients> dialogs = _contextDialogs.All;
            return Ok(dialogs);
        }

        /// <summary>
        /// Позволяет добавить клиента в диалог
        /// </summary>
        /// <param name="rgDialogsClients">Объект хранящий какие пользователи 
        /// взаимодействуют в рамках одного диалога</param>
        /// <returns>Информация о клиенте и диалоге в который он вступил</returns>
        [HttpPost]
        public ActionResult<RGDialogsClients> Post([FromBody] RGDialogsClients rgDialogsClients)
        {
            return Ok(_contextDialogs.Add(rgDialogsClients));
        }


        /// <summary>
        /// Позволяет удалить клиента из диалога
        /// </summary>
        /// <param name="rgDialogsClients">Объект хранящий какие пользователи 
        /// взаимодействуют в рамках одного диалога</param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult Delete(RGDialogsClients rgDialogsClients)
        {
            _contextDialogs.Delete(rgDialogsClients);
            return Ok();
        }

    }
}
