namespace IGB.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Patient_Services> Patient_Services { get; set; }
    }
}
