using Application.Features.Doctor.Commands.CreateDoctorRole;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("assign-doctor")]
        public async Task<IActionResult> CreateDoctorRole(CreateDoctorRoleCommand createDoctorRoleCommand)
        {
            var response = await _mediator.Send(createDoctorRoleCommand);
            return Ok(response);
        }

    }
}
