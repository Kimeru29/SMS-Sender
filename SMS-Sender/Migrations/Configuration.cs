namespace SMS_Sender.Migrations
{
    using SMS_Sender.Core.Models;
    using SMS_Sender.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SMS_SenderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SMS_SenderContext context)
        {
            context.Clientes.AddOrUpdate(c => c.Nombre,
                new Cliente()
                {
                    Nombre = "James T. Kirk",
                    Email = "James_Kirk_33@Federation.com",
                    Celular = "+010000000010",
                    Sexo = Sexo.Masculino,
                    Comentarios = "...",
                    //Fecha = DateTime.Now
                },
                new Cliente()
                {
                    Nombre = "Anakin Skywalker",
                    Email = "Anakin@JediCouncil.com",
                    Celular = "+020000000020",
                    Sexo = Sexo.Masculino,
                    Comentarios = "...",
                    //Fecha = DateTime.Now
                },
                new Cliente()
                {
                    Nombre = "Ellen Ripley",
                    Email = "Ellen@Yitani.com",
                    Celular = "+030000000300",
                    Sexo = Sexo.Femenino,
                    Comentarios = "...",
                    //Fecha = DateTime.Now
                }
            );
        }
    }
}
