using Microsoft.AspNetCore.Http;
using StreamlineAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.RRModels
{
    public class AademyRequest
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "Name must not exceed 50 characters.")]
        public String Name { get; set; } = null!;

        [Required(ErrorMessage = "AcademyName is required")]
        [StringLength(40, ErrorMessage = "Name must not exceed 50 characters.")]
        public String AcademyName { get; set; } = null!;

        [Required(ErrorMessage = "Address is required")]
        public String Address { get; set; } = null!;
        public Guid? CountryId { get; set; }
        public Guid? StateId { get; set; }
        public Guid? CityId { get; set; }
        //[Required(ErrorMessage = "Country is required")]
        //public String Country { get; set; } = null!;

        //[Required(ErrorMessage = "State is required")]
        //public String State { get; set; } = null!;

        //[Required(ErrorMessage = "City is required")]
        //public String City { get; set; } = null!;

        [Required(ErrorMessage = "PostalCode is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "PostalCode must contain only numbers")]
        [StringLength(8, ErrorMessage = "PostalCode must not exceed 8 characters.")]
        public String PostalCode { get; set; } = null!;

        [Required(ErrorMessage = "PhoneNumber is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "please enter valid phone number ")]
        public String PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Please enter valid Email")]
        public String Email { get; set; } = null!;

       
        public Guid? AcademyTypeId { get; set; }


        [Required(ErrorMessage = "Courseoffered is required")]
       
        public IFormFile? Logo { get; set; }
    }

    public class AcademyResponse :AademyRequest
    {
        public Guid Id { get; set; }
    }

    public class AcademyUpdateRequest:AcademyResponse 
    { 

    }
}
