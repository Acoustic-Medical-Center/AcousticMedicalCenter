using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Commands.Update
{
    public class UpdatePrescriptionCommand : IRequest<UpdatePrescriptionCommandResponse>, ISecuredRequest
    {
        public int PrescriptionId { get; set; }
        public string? MedicationDetails { get; set; }
        public string? DosageInstructions { get; set; }

        public string[] RequiredRoles => [];

        public class UpdatePrescriptionCommandHandler : IRequestHandler<UpdatePrescriptionCommand, UpdatePrescriptionCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IPrescriptionRepository _prescriptionRepository;
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IMapper _mapper;

            public UpdatePrescriptionCommandHandler(IHttpContextAccessor httpContextAccessor, IPrescriptionRepository prescriptionRepository, IAppointmentRepository appointmentRepository, IMapper mapper)
            {
                _httpContextAccessor = httpContextAccessor;
                _prescriptionRepository = prescriptionRepository;
                _appointmentRepository = appointmentRepository;
                _mapper = mapper;
            }
            public async Task<UpdatePrescriptionCommandResponse> Handle(UpdatePrescriptionCommand request, CancellationToken cancellationToken)
            {
                var doctorId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                var prescription = await _prescriptionRepository.GetAsync(predicate: p => p.Id == request.PrescriptionId && p.Appointment.DoctorId == doctorId, include: p => p.Include(pres => pres.Appointment));

                if (prescription != null)
                {
                    var newPrescription = new Prescription();
                    newPrescription.MedicationDetails = request.MedicationDetails != null ? request.MedicationDetails : prescription.MedicationDetails;
                    newPrescription.DosageInstructions = request.DosageInstructions != null ? request.DosageInstructions : prescription.DosageInstructions;
                    newPrescription.AppointmentId = prescription.AppointmentId;
                    await _prescriptionRepository.SoftDeleteAsync(prescription);
                    await _prescriptionRepository.AddAsync(newPrescription);
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
