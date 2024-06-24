using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Feedback.Query
{
    public class GetAllFeedbackQuery : IRequest<List<GetAllFeedbackQueryResponse>>, ISecuredRequest
    {
        public string[] RequiredRoles => [];

        public class GetAllFeedbackQueryHandler : IRequestHandler<GetAllFeedbackQuery, List<GetAllFeedbackQueryResponse>>
        {
            private readonly IFeedbackRepository _feedbackRepository;
            private readonly IMapper _mapper;

            public GetAllFeedbackQueryHandler(IFeedbackRepository feedbackRepository, IMapper mapper)
            {
                _feedbackRepository = feedbackRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllFeedbackQueryResponse>> Handle(GetAllFeedbackQuery request, CancellationToken cancellationToken)
            {
                var feedbacks = await _feedbackRepository.GetListAsync();
                var response = _mapper.Map<List<GetAllFeedbackQueryResponse>>(feedbacks);
                return response;
            }
        }
    }
}
