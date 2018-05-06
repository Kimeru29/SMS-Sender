using SMS_Sender.Core.Interfaces;
using SMS_Sender.Core.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SMS_Sender.Data.ImplementacionesInterfaces
{
    public class ClientesRepository : Repository<Cliente>, IClientesRepository
    {
        public ClientesRepository(SMS_SenderContext context)
            : base(context)
        {
        }

        public IEnumerable<Cliente> GetClientesEspecializado(int pagina)
        {
            return SMSContext.Clientes.OrderByDescending(c => c.Nombre).Take(pagina).ToList();
        }

        public SMS_SenderContext SMSContext
        {
            get { return Context as SMS_SenderContext; }
        }
    }


}