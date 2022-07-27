using System.ComponentModel.DataAnnotations;

namespace IGB.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Fullname is required!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email address is required!")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password do not match!")]
        public string ConfirmPassword { get; set; }
    }
}
