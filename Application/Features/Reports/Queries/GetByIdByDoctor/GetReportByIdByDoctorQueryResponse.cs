namespace Application.Features.Reports.Queries.GetByIdByDoctor
{
    public class GetReportByIdByDoctorQueryResponse
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string PatientBloodType { get; set; }
        public string CreatedDate { get; set; }
        public string Diagnosis { get; set; }
        public string ExaminationFindings { get; set; }
    }
}