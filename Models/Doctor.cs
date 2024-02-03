namespace HospitalBedManagement.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public int AssignedPatients { get; set; } = 0;
        public string Title { get; set; }
    }
}
