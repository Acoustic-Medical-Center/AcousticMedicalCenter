﻿using Application.Features.Doctor.Commands.Update;
using Application.Features.Doctor.Queries.GetAll;
using Application.Features.Doctor.Queries.GetById;
using Application.Features.User.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DoctorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll([FromQuery] GetAllDoctorQuery getAllDoctorQuery)
        {
            var response = await _mediator.Send(getAllDoctorQuery);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetByIdDoctorQuery { Id = id };
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctor(int id, [FromBody] UpdateDoctorCommand command)
        {
            if (id != command.DoctorId)
            {
                return BadRequest("Doktor ID'si eşleşmiyor.");
            }

            var result = await _mediator.Send(command);

            if (result == null)
            {
                return NotFound("Doktor bulunamadı.");
            }

            return Ok(result);
        }
    }
}
