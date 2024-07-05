using Application.Features.Prescriptions.Queries.GetAllByPatient;
using Application.Features.Reports.Commands.Create;
using Application.Features.Reports.Queries.GetAllByPatient;
using Application.Features.Reports.Queries.GetByIdByDoctor;
using Application.Features.Reports.Queries.GetByIdByPatient;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ReportController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ReportController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("reports")]
        public async Task<IActionResult> Add([FromBody] CreateReportCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        [HttpGet("patient/reports")]
        public async Task<IActionResult> GetAllReportsByPatient([FromQuery] GetAllReportsByPatientQuery getAllReportsByPatientQuery)
        {
            var response = await _mediator.Send(getAllReportsByPatientQuery);
            return Ok(response);
        }


        [HttpGet("patient/reports/{id}")]
        public async Task<IActionResult> GetReportById([FromRoute] int id)
        {
            var query = new GetPatientReportByIdQuery { ReportId = id };
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("doctor/reports/{id}")]
        public async Task<IActionResult> GetReportByIdByDoctor([FromRoute] GetReportByIdByDoctorQuery getReportByIdByDoctorQuery)
        {
            var response = await _mediator.Send(getReportByIdByDoctorQuery);
            return Ok(response);
        }


    }
}
