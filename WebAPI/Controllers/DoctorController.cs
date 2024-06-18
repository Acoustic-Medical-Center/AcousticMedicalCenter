using Application.Features.Doctor.Commands.Update;
using Application.Features.Doctor.Commands.UpdateByAdmin;
using Application.Features.Doctor.Queries.GetAll;
using Application.Features.Doctor.Queries.GetById;
using Application.Features.User.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DoctorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("doctors")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllDoctorQuery getAllDoctorQuery)
        {
            var response = await _mediator.Send(getAllDoctorQuery);
            return Ok(response);
        }

        [HttpGet("doctors/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetByIdDoctorQuery { Id = id };
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPut("doctors")]
        public async Task<IActionResult> UpdateDoctor([FromBody] UpdateDoctorCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("admin/doctors")]
        public async Task<IActionResult> UpdateDoctor([FromBody] UpdateDoctorByAdminCommand updateDoctorByAdminCommand)
        {
            var result = await _mediator.Send(updateDoctorByAdminCommand);
            return Ok(result);
        }
    }
}
