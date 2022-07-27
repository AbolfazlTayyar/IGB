namespace IGB.Models
{
    public class Patient_Services
    {
        public string PatientId { get; set; }
        public Patient Patient { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
