using Application.Features.Auth.Commands.Login;
using Application.Features.Doctor.Commands.CreateDoctorRole;
using Application.Features.User.Commands.Delete;
using Application.Features.User.Commands.Update;
using Application.Features.User.Queries.GetAll;
using Application.Features.User.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetById([FromQuery] UserGetByIdQuery userGetByIdQuery)
        {
            var response = await _mediator.Send(userGetByIdQuery);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllUserQuery userGetAllQuery)
        {
            var response = await _mediator.Send(userGetAllQuery);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Delete([FromQuery] DeleteUserCommand userDeleteCommand)
        {
            var response = await _mediator.Send(userDeleteCommand);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UserUpdateCommand userUpdateCommand)
        {
            var response = await _mediator.Send(userUpdateCommand);
            return Ok(response);
        }

        

    }
}
