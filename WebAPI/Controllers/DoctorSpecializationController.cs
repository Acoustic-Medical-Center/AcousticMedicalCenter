using Application.Features.Doctor.Queries.GetAll;
using Application.Features.Doctor.Queries.GetAllSpecialization;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorSpecializationController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DoctorSpecializationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllSpecializationQuery GetAllSpecializationQuery)
        {
            var response = await _mediator.Send(GetAllSpecializationQuery);
            return Ok(response);
        }
    }
}
