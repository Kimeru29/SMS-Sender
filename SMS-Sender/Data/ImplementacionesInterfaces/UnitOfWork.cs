using SMS_Sender.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Sender.Data.ImplementacionesInterfaces
{
    public class UnitOfWork : IUnifOfWork
    {
        private readonly SMS_SenderContext _context;

        public UnitOfWork(SMS_SenderContext context)
        {
            _context = context;
            Clientes = new ClientesRepository(_context);
        }

        public IClientesRepository Clientes { get; private set; }

        public void Complete() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
