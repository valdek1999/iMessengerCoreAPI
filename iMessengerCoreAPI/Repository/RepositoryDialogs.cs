using iMessengerCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Repository
{
    public class RepositoryDialogs : IRepository<RGDialogsClients>
    {

        private readonly List<RGDialogsClients> _dialogContext;
        public IEnumerable<RGDialogsClients> All => _dialogContext;

        /// <summary>
        /// Количество экземпляров RGDialogsClients
        /// </summary>
        public int Count => _dialogContext.Count;
        public RepositoryDialogs()
        {
            _dialogContext = new RGDialogsClients().Init();
        }

        /// <summary>
        /// Получить такой GUID диалога, в котором 
        /// есть все переданные клиенты, участвующие в диалоге.
        /// Если нет такого диалога -> возращается пустой GUID.
        /// </summary>
        /// <param name="clients"></param>
        /// <returns></returns>
        public Guid FindDialogID(List<Guid> clients)
        {
            var dialogs = _dialogContext.GroupBy(x => x.IDRGDialog);
            foreach(var dialog in dialogs)
            {
                var countIntersect = dialog
                    .Select(x => x.IDClient)
                    .Intersect(clients)
                    .Count();
                if(clients.Count == countIntersect)
                {
                    return dialog.Key;
                }
            }
            return new Guid();
        }
        /// <summary>
        /// Добавить объект который хранит данные о том какой пользователь вступил в диалог.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public RGDialogsClients Add(RGDialogsClients entity)
        {
            _dialogContext.Add(entity);
            //TODO: добавить в бд и сохранить
            return entity;
        }
        /// <summary>
        /// Удалить данные cущности - диалога с клиентом
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(RGDialogsClients entity)
        {
            //TODO: удалить из бд и сохранить
            _dialogContext.Remove(entity);
        }

        /// <summary>
        /// Обновить данные сущности диалога с клиентом
        /// </summary>
        /// <param name="entity"></param>
        public void Update(RGDialogsClients entity)
        {
            //TODO: допилить метод.
            throw new NotImplementedException();
        }
    }
}
