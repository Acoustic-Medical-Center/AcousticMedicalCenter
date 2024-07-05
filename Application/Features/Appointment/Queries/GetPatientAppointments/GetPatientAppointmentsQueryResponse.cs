﻿using Domain.Entities;

namespace Application.Features.Appointment.Queries.GetPatientAppointments
{
    public class GetPatientAppointmentsQueryResponse
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentTime { get; set; }
        public AppointmentStatus Status { get; set; }
        public string? BloodType { get; set; }
        public string PatientPhoneNumber { get; set; }
        public string PatientGender { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string? MedicationDetails { get; set; }
        public string? DosageInstructions { get; set; }
        public string? ExaminationFindings { get; set; }
        public string? Diagnosis { get; set; }
    }
}