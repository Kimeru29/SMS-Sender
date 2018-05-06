using System;

namespace SMS_Sender.Core.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public string Celular { get; set; }
        public string Comentarios { get; set; }
    }
}