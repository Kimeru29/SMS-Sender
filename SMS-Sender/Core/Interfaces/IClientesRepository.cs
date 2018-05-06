using SMS_Sender.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Sender.Core.Interfaces
{
    public interface IClientesRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> GetClientesEspecializado(int pagina);
    }
}
