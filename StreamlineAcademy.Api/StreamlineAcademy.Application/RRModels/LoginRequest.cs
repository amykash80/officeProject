using StreamlineAcademy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.RRModels
{
    public class LoginRequest
    {

        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
    }

    public class LoginResponse 
    {
        //public Guid Id { get; set; }
        public string FullName {  get; set; } =null!;
        public UserRole UserRole { get; set; } 
        public string Token { get; set; } = null!;
    }
}
