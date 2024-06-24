using Application.Features.Doctor.Commands.Update;
using Application.Features.Doctor.Queries.GetById;
using Application.Features.Patients.Commands.Update;
using Application.Features.Patients.Queries.GetAll;
using Application.Features.Patients.Queries.GetById;
using Application.Features.Patients.Queries.GetPatientById;
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

        [HttpGet("doctor/myPatients")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllPatientQuery getAllPatientQuery)
        {
            var response = await _mediator.Send(getAllPatientQuery);
            return Ok(response);
        }

        [HttpGet("doctor/myPatients/{id}")]
        public async Task<IActionResult> GetById([FromRoute] GetPatientByIdQuery getPatientByIdQuery)
        {
            var response = await _mediator.Send(getPatientByIdQuery);
            return Ok(response);
        }


        [HttpGet("patient/settings")]
        public async Task<IActionResult> GetPatientByIdSelfQuery([FromQuery] GetPatientByIdSelfQuery getPatientByIdSelfQuery)
        {
            var response = await _mediator.Send(getPatientByIdSelfQuery);
            return Ok(response);
        }

        //Update
        [HttpPut("patient/settings")]
        public async Task<IActionResult> UpdatePatient([FromBody] UpdatePatientCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
