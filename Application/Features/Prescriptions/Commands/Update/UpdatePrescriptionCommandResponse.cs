namespace Application.Features.Prescriptions.Commands.Update
{
    public class UpdatePrescriptionCommandResponse
    {
        public int Id { get; set; }
        public string MedicationDetails { get; set; }
        public string DosageInstructions { get; set; }
    }
}