using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Producer
    {
        public int ProducerId { get; set; }

        [Required(ErrorMessage = "Please set your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please set your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please set your first name")]
        [Display(Name = "First number")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please set your last name")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please set organization")]
        public string Organization { get; set; }

        [Required(ErrorMessage = "Please set link to organization")]
        [Display(Name = "Website")]
        public string LinkToOrg { get; set; }

        [Required(ErrorMessage = "Please set your phone number")]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public bool IsApproved { get; set; }
    }
}