using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Sender.Core.Interfaces
{
    public interface IUnifOfWork : IDisposable
    {
        IClientesRepository Clientes { get; }

        void Complete();
    }

}
