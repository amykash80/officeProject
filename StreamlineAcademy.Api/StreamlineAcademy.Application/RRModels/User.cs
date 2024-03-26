using StreamlineAcademy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.RRModels
{
    public class UserRegistrationRequest
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "Name must not exceed 50 characters.")]
        public string Name { get; set; } = null!;
     
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "PostalCode is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "PostalCode must contain only numbers")]
        [StringLength(8, ErrorMessage = "PostalCode must not exceed 8 characters.")]
        public string PostalCode { get; set; } = null!;

        [Required(ErrorMessage = "PhoneNumber is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "please enter valid phone number ")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Please enter valid Email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;

    }

    public class LoginRequest
    {

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
    }

    public class LoginResponse
    {
        public string FullName { get; set; } = null!;
        public UserRole UserRole { get; set; }
        public string Token { get; set; } = null!;
    }

    public class ChangePasswordRequest
    {

        [Required(ErrorMessage = "Enter Old Password")]
        public string OldPassword { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter Password"), DataType(DataType.Password)]
        public string NewPassword { get; set; } = string.Empty;


        [Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
