using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.ForgotPassword
{
    public class ForgotPasswordCommand : IRequest
    {

        public string Email { get; set; }

        public class ForgotPasswordCommandHandler : IRequestHandler<ForgotPasswordCommand>
        {

            Task IRequestHandler<ForgotPasswordCommand>.Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
