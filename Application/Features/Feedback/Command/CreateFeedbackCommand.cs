using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Feedback.Command
{
    public class CreateFeedbackCommand : IRequest<CreateFeedbackCommandResponse>, ISecuredRequest
    {
        public string FeedbackSubject { get; set; }
        public string FeedbackMessage { get; set; }
        public string[] RequiredRoles => [];

        public class CreateFeedbackCommandHandler : IRequestHandler<CreateFeedbackCommand, CreateFeedbackCommandResponse>
        {
            private readonly IFeedbackRepository _feedbackRepository;
            private readonly IMapper _mapper;

            public CreateFeedbackCommandHandler(IFeedbackRepository feedbackRepository, IMapper mapper)
            {
                _feedbackRepository = feedbackRepository;
                _mapper = mapper;
            }
            public async Task<CreateFeedbackCommandResponse> Handle(CreateFeedbackCommand request, CancellationToken cancellationToken)
            {
                var feedbackToAdd = new Domain.Entities.Feedback()
                { FeedbackSubject = request.FeedbackSubject, FeedbackMessage = request.FeedbackMessage };
                await _feedbackRepository.AddAsync(feedbackToAdd);
                return new() { };
            }
        }
    }
}