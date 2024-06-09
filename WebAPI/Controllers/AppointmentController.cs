using Application.Features.Appointment.Commands.Create;
using Application.Features.Appointment.Commands.Delete;
using Application.Features.Appointment.Commands.DeleteByClaim;
using Application.Features.Appointment.Queries.GetAllByPatient;
using Application.Features.Auth.Commands.Login;
using Application.Features.User.Commands.Delete;
using Application.Services;
using Infrastructure.Services.EmailService;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateAppointmentByPatient(CreateAppointmentCommand createAppointmentCommand)
        {
            var response = await _mediator.Send(createAppointmentCommand);
            if (response != null) // Randevu oluşturulduktan sonra e-posta gönder
            {
                string doctorEmailSubject = "Yeni Randevu Bilgisi";
                string doctorEmailBody = $"Sayın Dr. {createAppointmentCommand.DoctorName},<br>Yeni bir randevu oluşturuldu.<br><br>Hasta: {createAppointmentCommand.PatientName}<br>Randevu Tarihi: {createAppointmentCommand.AppointmentTime}";

                string patientEmailSubject = "Randevu Bilgisi";
                string patientEmailBody = $"Sayın {createAppointmentCommand.PatientName},<br>Randevu bilgileriniz aşağıdadır.<br><br>Doktor: Dr. {createAppointmentCommand.DoctorName}<br>Randevu Tarihi: {createAppointmentCommand.AppointmentTime}";

                await _mailService.SendEmailAsync(createAppointmentCommand.DoctorEmail, doctorEmailSubject, doctorEmailBody);
                await _mailService.SendEmailAsync(createAppointmentCommand.PatientEmail, patientEmailSubject, patientEmailBody);
            }
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAppointmentsByPatient([FromQuery] GetAllAppointmensByPatientQuery getAllAppointmentsByUserQuery)
        {
            var response = await _mediator.Send(getAllAppointmentsByUserQuery);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Delete([FromQuery] DeleteAppointmentByPatientCommand deleteAppointmentByUserCommand)
        {
            var response = await _mediator.Send(deleteAppointmentByUserCommand);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> DeleteByClaim([FromQuery] DeleteAppointmentByClaimCommand deleteAppointmentByClaimCommand)
        {
            var response = await _mediator.Send(deleteAppointmentByClaimCommand);
            return Ok(response);
        }

    }
}
