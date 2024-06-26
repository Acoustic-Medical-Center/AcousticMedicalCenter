using Application.Features.Auth.Commands.Register;
using Application.Features.Feedback.Query;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Feedback.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.Feedback, GetAllFeedbackQueryResponse>().ReverseMap();
        }
    }
}
