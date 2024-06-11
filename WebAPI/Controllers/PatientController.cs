using Application.Features.Patients.Queries.GetAll;
using Application.Features.Patients.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PatientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("doctor/mypatients")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllPatientQuery getAllPatientQuery)
        {
            var response = await _mediator.Send(getAllPatientQuery);
            return Ok(response);
        }

        [HttpGet("doctor/mypatients/{PatientId}")]
        public async Task<IActionResult> GetById([FromRoute] GetPatientByIdQuery getPatientByIdQuery)
        {
            var response = await _mediator.Send(getPatientByIdQuery);
            return Ok(response);
        }
    }
}
