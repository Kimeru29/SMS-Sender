using System;

namespace SMS_Sender.Core.Models
{
    public class Cliente
    {
        public DateTime Fecha { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte Edad { get; set; }
        public Sexo Sexo { get; set; }
        public int Telefono { get; set; }
        public Decimal Monto { get; set; }
        public string DestinoCredito { get; set; }
    }
}