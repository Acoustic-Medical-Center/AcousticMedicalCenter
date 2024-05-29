using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(i => i.FirstName).NotEmpty().WithMessage("İsim alanı boş olamaz.");
            RuleFor(i => i.LastName).NotEmpty().WithMessage("İsim alanı boş olamaz.");
            RuleFor(i => i.PhoneNumber).NotEmpty().WithMessage("İsim alanı boş olamaz.");
            RuleFor(i => i.Password).NotEmpty().WithMessage("İsim alanı boş olamaz.");



            //// Kendi kuralımız.
            //RuleFor(i => i.Name).Must(StartsWithA).WithMessage("İsim alanı a harfi ile başlamalıdır.");
        }

        //public bool StartsWithA(string name)
        //{
        //    return name.StartsWith("A");
        //}
    }
}
