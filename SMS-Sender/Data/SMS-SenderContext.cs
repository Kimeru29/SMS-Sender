using SMS_Sender.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SMS_Sender.Data
{
    public class SMS_SenderContext : ApplicationDbContext
    {
        
        public SMS_SenderContext()
            : base("SMS-SenderContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SMS_SenderContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}