using Application.Features.Appointment.Commands.Create;
using Application.Features.Appointment.Commands.Delete;
using Application.Features.Appointment.Commands.DeleteByClaim;
using Application.Features.Appointment.Queries.GelAllByDoctor;
using Application.Features.Appointment.Queries.GetAllByClaim;
using Application.Features.Appointment.Queries.GetAllByPatient;
using Application.Features.Appointment.Queries.GetByIdAdmin;
using Application.Features.Auth.Commands.Login;
using Application.Features.User.Commands.Delete;
using Application.Services;
using Infrastructure.Services.EmailService;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMailService _mailService;

        public AppointmentController(IMediator mediator, IMailService mailService)
        {
            _mediator = mediator;
            _mailService = mailService;
        }

        [HttpPost("patient/appointments")]
        public async Task<IActionResult> CreateAppointmentByPatient(CreateAppointmentCommand createAppointmentCommand)
        {
            var response = await _mediator.Send(createAppointmentCommand);
            return Ok(response);
        }

        [HttpGet("patient/appointments")]
        public async Task<IActionResult> GetAllAppointmentsByPatient([FromQuery] GetAllAppointmensByPatientQuery getAllAppointmentsByUserQuery)
        {
            var response = await _mediator.Send(getAllAppointmentsByUserQuery);
            return Ok(response);
        }

        [HttpGet("doctor/appointments")]
        public async Task<IActionResult> GetAllAppointmentsByDoctor([FromQuery] GetAllAppointmentsByDoctorQuery getAllAppointmentsByDoctorQuery)
        {
            var response = await _mediator.Send(getAllAppointmentsByDoctorQuery);
            return Ok(response);
        }

        [HttpGet("admin/appointments")]
        public async Task<IActionResult> GetAllAppointmentsByClaim([FromRoute] GetAllAppointmentsByClaimQuery getAllAppointmentsByClaimQuery)
        {
            var response = await _mediator.Send(getAllAppointmentsByClaimQuery);
            return Ok(response);
        }

        [HttpGet("admin/appointments/{id}")]
        public async Task<IActionResult> GetAllAppointmentsByIdAdmin([FromRoute] GetAppointmentByIdAdminQuery getAppointmentByIdAdminQuery)
        {
            var response = await _mediator.Send(getAppointmentByIdAdminQuery);
            return Ok(response);
        }

        [HttpDelete("patient/appointments/{id}")]
        public async Task<IActionResult> Delete([FromQuery] DeleteAppointmentByPatientCommand deleteAppointmentByUserCommand)
        {
            var response = await _mediator.Send(deleteAppointmentByUserCommand);
            return Ok(response);
        }

        [HttpDelete("admin/appointments/{id}")]
        public async Task<IActionResult> DeleteByClaim([FromQuery] DeleteAppointmentByClaimCommand deleteAppointmentByClaimCommand)
        {
            var response = await _mediator.Send(deleteAppointmentByClaimCommand);
            return Ok(response);
        }

    }
}
