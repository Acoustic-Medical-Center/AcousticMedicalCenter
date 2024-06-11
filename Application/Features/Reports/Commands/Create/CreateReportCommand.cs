using Application.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reports.Commands.Create
{
    public class CreateReportCommand : IRequest<CreateReportCommandResponse>
    {
        public string AppointmentId { get; set; }
        public string ExaminationFindings { get; set; }
        public string Diagnosis { get; set; }

        public class CreateReportCommandHandler : IRequestHandler<CreateReportCommand, CreateReportCommandResponse>
        {

            private readonly IReportRepository _reportRepository;
            private readonly IMapper _mapper;
            private readonly IAppointmentRepository _appointmentRepository;


            public Task<CreateReportCommandResponse> Handle(CreateReportCommand request, CancellationToken cancellationToken)
            {


                throw new NotImplementedException();
            }
        }
    }
}
