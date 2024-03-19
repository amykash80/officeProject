using Microsoft.AspNetCore.Http;
using StreamlineAcademy.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Domain.Entities
{
    public class Academy:BaseModel
    {
        public String Name { get; set; } = null!;
        public String AcademyName { get; set; } =null!;
        public String Address { get; set; } = null!;
        //public String Country { get; set; } = null!;
        //public String State { get; set; } = null!;
        //public String City { get; set; } = null!;
        public String PostalCode { get; set; } = null!;
        public String PhoneNumber { get; set; } = null!;
        public String Email { get; set; } = null!;
        //public String AcademyType { get; set; } = null!;
        public Guid? CountryId { get; set; } 
        public Guid? StateId { get; set; }
        public Guid? CityId { get; set; }

        public Guid? AcademyTypeId { get; set; }

        // Navigation property to AcademyType
        #region Navigation
        [ForeignKey(nameof(AcademyTypeId))]
        public AcademyType AcademyType { get; set; } = null!;

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [ForeignKey(nameof(StateId))]
        public State State { get; set; } = null!;

        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;
        #endregion




    }
}
