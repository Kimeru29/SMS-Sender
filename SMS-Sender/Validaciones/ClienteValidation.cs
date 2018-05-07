using FluentValidation;
using SMS_Sender.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Sender.Validaciones
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Nombre).NotEmpty();
        }
    }
}