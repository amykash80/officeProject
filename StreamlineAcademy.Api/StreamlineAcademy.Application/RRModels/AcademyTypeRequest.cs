using StreamlineAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.RRModels
{
    public class AcademyTypeRequest
    {
        public string Name { get; set; } = null!;
    }

    public class AcademyTypeResponse: AcademyTypeRequest
    {
        public Guid Id { get; set; }
    }
}
