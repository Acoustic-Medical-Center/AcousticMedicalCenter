﻿using Application.Features.Appointment.Queries.GetAllByPatient;
using Application.Features.Doctor.Queries.GetById;
using Application.Features.Prescriptions.Commands.Create;
using Application.Features.Prescriptions.Queries.GetAllByAdmin;
using Application.Features.Prescriptions.Queries.GetAllByDoctor;
using Application.Features.Prescriptions.Queries.GetAllByPatient;
using Application.Features.Prescriptions.Queries.GetByIdPatient;
using Application.Features.Reports.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/prescriptions")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {

        private readonly IMediator _mediator;

        public PrescriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreatePrescriptionCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(new
            {
                Data = response,
                Message = "Prescription created successfully"
            });

        }

        [HttpGet("/by-patient")]
        public async Task<IActionResult> GetAllPrescriptionsByPatient([FromQuery] GetAllPrescriptionsByPatientQuery getAllPrescriptionsByPatientQuery)
        {
            var response = await _mediator.Send(getAllPrescriptionsByPatientQuery);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrescriptionById([FromRoute] int id)
        {
            var query = new GetPatientPrescriptionByIdQuery { PrescriptionId = id };
            var response = await _mediator.Send(query);
            return Ok(response);
        }


        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var query = new GetByIdDoctorQuery { Id = id };
        //    var response = await _mediator.Send(query);
        //    return Ok(response);
        //}

        [HttpGet("/by-doctor")]
        public async Task<IActionResult> GetAllPrescriptionsByDoctor([FromQuery] GetAllPrescriptionsByDoctorQuery getAllPrescriptionsByDoctorQuery)
        {
            var response = await _mediator.Send(getAllPrescriptionsByDoctorQuery);
            return Ok(response);


        }


        [HttpGet("/by-admin")]
        public async Task<IActionResult> GetAllPrescriptsionByAdmin([FromQuery] GetAllPrescriptionsByAdminQuery getAllPrescriptionsByAdminQuery)
        {
            var response = await _mediator.Send(getAllPrescriptionsByAdminQuery);
            return Ok(response);
        }


    }
}