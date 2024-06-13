using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Commands.Create
{
    public class CreatePrescriptionCommand : IRequest<CreatePrescriptionCommandResponse>
    {
        public int AppointmentId { get; set; }
        public string MedicationDetails { get; set; }
        public string DosageInstructions { get; set; }



        public class CreatePrescriptionCommandHandler : IRequestHandler<CreatePrescriptionCommand, CreatePrescriptionCommandResponse>
        {

            private readonly IMapper _mapper;
            private readonly IPrescriptionRepository _prescriptionRepository;

            public CreatePrescriptionCommandHandler(IMapper mapper, IPrescriptionRepository prescriptionRepository)
            {
                _mapper = mapper;
                _prescriptionRepository = prescriptionRepository;
            }

            public async Task<CreatePrescriptionCommandResponse> Handle(CreatePrescriptionCommand request, CancellationToken cancellationToken)
            {
                Prescription mappedPrescription = _mapper.Map<Prescription>(request);

                await _prescriptionRepository.AddAsync(mappedPrescription);

                CreatePrescriptionCommandResponse response = _mapper.Map<CreatePrescriptionCommandResponse>(mappedPrescription);

                return response;
            }
        }
    }
}
