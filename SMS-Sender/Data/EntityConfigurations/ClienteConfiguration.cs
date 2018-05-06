using SMS_Sender.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SMS_Sender.Data.EntityConfigurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            Property(c => c.Nombre)
                .IsRequired();

            Property(c => c.Email)
                .IsRequired();

            Property(c => c.Celular)
                .IsRequired();
        }
    }
}