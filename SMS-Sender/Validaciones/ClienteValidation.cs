using FluentValidation;
using SMS_Sender.Core.Models;

namespace SMS_Sender.Validaciones
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Nombre).NotEmpty().WithMessage("El campo 'Nombre' es requerido");
            RuleFor(c => c.Email).NotEmpty().WithMessage("El campo 'Email' es requerido");
            RuleFor(c => c.Celular).NotEmpty().WithMessage("El campo 'Celular' es requerido");

            RuleFor(c => c.Nombre).Matches(@"^[a-zA-Z\s]*$").WithMessage("El Campo 'Nombre' solo acepta letras.");
            RuleFor(c => c.Email).Matches(@"^[\w.-]+@(?=[a-z\d][^.]*\.)[a-z\d.-]*(?<![.-])$").WithMessage("La dirección de 'Email' es inválida.");
            RuleFor(c => c.Celular).Length(10).WithMessage("'Celular' debe conformarse de 10 números");

        }
    }
}