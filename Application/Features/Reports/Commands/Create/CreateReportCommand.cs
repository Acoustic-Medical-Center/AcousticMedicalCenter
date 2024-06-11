using Application.Repositories;
using AutoMapper;
using Domain.Entities;
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


        public int AppointmentId { get; set; }
        public string ExaminationFindings { get; set; }
        public string Diagnosis { get; set; }

        public class CreateReportCommandHandler : IRequestHandler<CreateReportCommand, CreateReportCommandResponse>
        {

            private readonly IReportRepository _reportRepository;
            private readonly IMapper _mapper;
            private readonly IAppointmentRepository _appointmentRepository;


            public CreateReportCommandHandler(IReportRepository reportRepository, IMapper mapper, IAppointmentRepository appointmentRepository)
            {
                _reportRepository = reportRepository;
                _mapper = mapper;
                _appointmentRepository = appointmentRepository;
            }

            public async Task<CreateReportCommandResponse> Handle(CreateReportCommand request, CancellationToken cancellationToken)
            {

                Report report = _mapper.Map<Report>(request);
                await _reportRepository.AddAsync(report);

                CreateReportCommandResponse response = _mapper.Map<CreateReportCommandResponse>(report);
                return response;
            }
        }

    }
}
