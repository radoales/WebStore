namespace WebStore.MVC.ViewModels.Identity
{
    using System.ComponentModel.DataAnnotations;
    using static WebConstants;
    public class RegisterRequestModel
    {
        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        [MinLength(5, ErrorMessage = "Username is too short")]
        [MaxLength(20, ErrorMessage = "Username is too long")]
        [RegularExpression(@"^[a-zA-Z0-9_.-]*$", ErrorMessage ="Invalid Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        [MaxLength(200, ErrorMessage ="Email too long")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage ="Invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        [MinLength(8, ErrorMessage ="Password too short")]
        [MaxLength(16, ErrorMessage = "Password too long")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
