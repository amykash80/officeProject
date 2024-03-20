using StreamlineAcademy.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Domain.Entities
{
    public class AcademyDestinations:BaseModel
    {


        public Guid AcademyId { get; set; }

        [ForeignKey(nameof(AcademyId))]
        public Academy Academy { get; set; } = null!;
        public Guid CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        public Guid StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public State State { get; set; } = null!;

        public Guid CityId { get; set; }
        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;
    }
}
