using iMessengerCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Repository
{
    public class RepositoryDialogs : IRepository<RGDialogsClients>
    {

        private readonly List<RGDialogsClients> _context;
        public IEnumerable<RGDialogsClients> All => _context;

        public int Count => _context.Count;
        public RepositoryDialogs()
        {
            _context = new RGDialogsClients().Init();
        }

        public RGDialogsClients Add(RGDialogsClients entity)
        {
            _context.Add(entity);
            //TODO: добавить в бд и сохранить
            return entity;
        }

        public RGDialogsClients Add(string IDClient, string IDRGDialog)
        {
            var newDialogClient = new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = new Guid(IDRGDialog),
                IDClient = new Guid(IDClient)
            };
            _context.Add(newDialogClient);
            //TODO: добавить в бд и сохранить
            return newDialogClient;
        }

        public void Delete(RGDialogsClients entity)
        {

        }

        public IEnumerable<RGDialogsClients> FindAll(Func<RGDialogsClients, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public RGDialogsClients FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(RGDialogsClients entity)
        {
            throw new NotImplementedException();
        }
    }
}
