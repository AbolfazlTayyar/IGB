using Microsoft.AspNetCore.Identity;

namespace IGB.Models
{
    public class Patient : IdentityUser
    {
        public string FullName { get; set; }

        public List<Patient_Services> Patient_Services { get; set; }
    }
}
