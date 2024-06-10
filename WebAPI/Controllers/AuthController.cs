using Application.Features.Auth.Commands.ForgotPassword;
using Application.Features.Auth.Commands.Login;
using Application.Features.Auth.Commands.Register;
using Core.Utilities.JWT;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginCommand loginCommand)
        {
            AccessToken response = await _mediator.Send(loginCommand);
            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterCommand registerCommand)
        {
            await _mediator.Send(registerCommand);
            return Ok();
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgetPassword([FromBody] ForgotPasswordCommand forgotPasswordCommand)
        {

            await Task.CompletedTask;
            return Ok(new { Message = "Forget password request received." });
        }
    }
}
