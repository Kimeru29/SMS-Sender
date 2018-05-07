using FluentValidation;
using SMS_Sender.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SMS_Sender.Validaciones
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Nombre).NotEmpty().WithMessage("El campo 'Nombre' es requerido");
            RuleFor(c => c.Email).NotEmpty().WithMessage("El campo 'Email' es requerido");
            RuleFor(c => c.Celular).NotEmpty().WithMessage("El campo 'Celular' es requerido");

            RuleFor(c => c.Nombre).Must(NombreSoloLetras).WithMessage("El Campo 'Nombre' solo acepta letras.");
            RuleFor(c => c.Email).Must(EmailValido).WithMessage("La dirección de 'Email' es inválida.");
            RuleFor(c => c.Celular).Length(10);

        }

        private Regex GetRegex(string regex) => new Regex(regex);

        private bool NombreSoloLetras(string nombre) => GetRegex("@^[a-zA-Z]+$").IsMatch(nombre = "");

        private bool EmailValido(string email) => GetRegex(@"@^[\w.-]+@(?=[a-z\d][^.]*\.)[a-z\d.-]*(?<![.-])$").IsMatch(email = "");


        
    }
}