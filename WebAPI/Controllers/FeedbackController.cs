using Application.Features.Doctor.Queries.GetAll;
using Application.Features.Feedback.Command;
using Application.Features.Feedback.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeedbackController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("feedback")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllFeedbackQuery getAllFeedbackQuery)
        {
            var response = await _mediator.Send(getAllFeedbackQuery);
            return Ok(response);
        }

        [HttpPost("feedback")]
        public async Task<IActionResult> CreateFeedback([FromBody] CreateFeedbackCommand createFeedbackCommand)
        {
            var response = await _mediator.Send(createFeedbackCommand);
            return Ok(response);
        }

    }
}
