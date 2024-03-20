using StreamlineAcademy.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Domain.Entities
{
    public class Country:BaseModel
    {
        
        public string CountryName { get; set; } = null!;
    }

    public class State:BaseModel
    {
        
        public string StateName { get; set; } = null!;
        public Guid? CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } =null!;
    }

    public class City:BaseModel
    {
        public string CityName { get; set; } =null!;
        
        public Guid? StateId { get; set; }

        [ForeignKey(nameof(StateId))]
        public State State { get; set; } =null !;

    }
}
