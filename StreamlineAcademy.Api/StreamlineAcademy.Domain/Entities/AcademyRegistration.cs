﻿using Microsoft.AspNetCore.Http;
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
        public string Name { get; set; } = null!;
        public string AcademyName { get; set; } =null!;
        public string Address { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Guid AcademyTypeId { get; set; }

        [ForeignKey(nameof(AcademyTypeId))]
        public AcademyType AcademyType { get; set; } = null!;

       





    }
}