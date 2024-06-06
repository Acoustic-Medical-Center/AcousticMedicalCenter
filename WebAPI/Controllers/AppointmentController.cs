﻿using Application.Features.Appointment.Commands.Create;
using Application.Features.Appointment.Queries.GetAllByPatient;
using Application.Features.Auth.Commands.Login;
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

        public AppointmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateAppointmentByPatient(CreateAppointmentCommand createAppointmentCommand)
        {
            var response = await _mediator.Send(createAppointmentCommand);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAppointmentsByPatient([FromQuery] GetAllAppointmensByPatientQuery getAllAppointmentsByUserQuery)
        {
            var response = await _mediator.Send(getAllAppointmentsByUserQuery);
            return Ok(response);
        }

    }
}
