using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Please complete this mandatory name field.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please complete this mandatory surname field.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please complete this mandatory city field.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please complete this mandatory username field.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please complete this mandatory mail field.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Please complete this mandatory password field.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please complete this mandatory password field.")]
        [Compare("Password", ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }
    }
}
