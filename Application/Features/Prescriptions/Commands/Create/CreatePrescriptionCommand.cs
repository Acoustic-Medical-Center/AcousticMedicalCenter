using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Commands.Create
{
    public class CreatePrescriptionCommand : IRequest<CreatePrescriptionCommandResponse>, ISecuredRequest
    {
        public int AppointmentId { get; set; }
        public string MedicationDetails { get; set; }
        public string DosageInstructions { get; set; }

        public string[] RequiredRoles => [];

        public class CreatePrescriptionCommandHandler : IRequestHandler<CreatePrescriptionCommand, CreatePrescriptionCommandResponse>
        {

            private readonly IMapper _mapper;
            private readonly IPrescriptionRepository _prescriptionRepository;
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public CreatePrescriptionCommandHandler(IMapper mapper, IPrescriptionRepository prescriptionRepository, IAppointmentRepository appointmentRepository, IHttpContextAccessor httpContextAccessor)
            {
                _mapper = mapper;
                _prescriptionRepository = prescriptionRepository;
                _appointmentRepository = appointmentRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<CreatePrescriptionCommandResponse> Handle(CreatePrescriptionCommand request, CancellationToken cancellationToken)
            {
                var doctorId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                var appointment = await _appointmentRepository.GetAsync(predicate: a => a.DoctorId == doctorId && a.Id == request.AppointmentId);
                if (appointment != null)
                {
                    var mappedPrescription = _mapper.Map<Prescription>(request);
                    await _prescriptionRepository.AddAsync(mappedPrescription);
                }
                else
                {
                    throw new Exception("Bu randevuya reçete yazamazsınız");
                }
                return new();
            }
        }
    }
}
