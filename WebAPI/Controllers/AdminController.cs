using Application.Features.Doctor.Commands.CreateDoctorRole;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("doctor/[action]")]
        public async Task<IActionResult> CreateDoctorRole(CreateDoctorRoleCommand createDoctorRoleCommand)
        {
            var response = await _mediator.Send(createDoctorRoleCommand);
            return Ok(response);
        }

    }
}
