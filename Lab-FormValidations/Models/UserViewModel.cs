using System.ComponentModel.DataAnnotations;
using Lab_FormValidations.Attributes;


namespace Lab_FormValidations.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter the Password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", 
            ErrorMessage = "Password Required(1 Uppercase, 1 Number, 1 Special Char and 1 Lowercase Char) with Min Length 8 Chars ")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please Enter Confirm Password")]
        [Compare("Password", ErrorMessage ="Confirm Password Doesn't match")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^\d{10}$" , ErrorMessage ="Please enter 10 digit number")]
        public string? Contact { get; set; } // question mark means it can hold the null value

        [Required(ErrorMessage ="Gender is required")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please accept terms")]
        public bool Terms { get; set; }
    }
}
