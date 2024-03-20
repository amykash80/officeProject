using Microsoft.AspNetCore.Http;
using StreamlineAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.RRModels
{
    public class AcademyRequest
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "Name must not exceed 50 characters.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "AcademyName is required")]
        [StringLength(40, ErrorMessage = "Name must not exceed 50 characters.")]
        public string AcademyName { get; set; } = null!;

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "PostalCode is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "PostalCode must contain only numbers")]
        [StringLength(8, ErrorMessage = "PostalCode must not exceed 8 characters.")]
        public string PostalCode { get; set; } = null!;

        [Required(ErrorMessage = "PhoneNumber is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "please enter valid phone number ")]
        public String PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Please enter valid Email")]
        public String Email { get; set; } = null!;

        public Guid AcademyTypeId { get; set; }

       // public IFormFile? Logo { get; set; }
    }


    public class AcademyDestinationRequest
    {

        public Guid CountryId { get; set; }

        public Guid StateId { get; set; }

        public Guid CityId { get; set; }
    }

    public class AcademyRegistrationRequest

    {
        public AcademyRequest AcademyRequest { get; set; } = null!;
        public List<AcademyDestinationRequest> AcademyDestinations { get; set; } = null!;
    }



    public class AcademyResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string AcademyName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? AcademyType { get; set; }
        public List<Country>? Countries { get; set; }

        public List<State>? State { get; set; }
        public List<City>? City { get; set; }
        public class AcademyUpdateRequest : AcademyResponse
        {

        }
    }
}
