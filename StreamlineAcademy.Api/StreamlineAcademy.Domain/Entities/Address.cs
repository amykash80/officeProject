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
		public string? CountryName { get; set; }

		#region navigation
		public ICollection<Academy>? Academies { get; set; }
		#endregion
	}

	public class State:BaseModel
    {
        
        public string? StateName { get; set; }
        public Guid? CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } =null!;

		#region navigation
		public ICollection<Academy>? Academies { get; set; }
		#endregion

	}

	public class City:BaseModel
    {
        public string? CityName { get; set; }
        public Guid? StateId { get; set; }

        [ForeignKey(nameof(StateId))]
        public State? State { get; set; }

		#region navigation
		public ICollection<Academy>? Academies { get; set; }
		#endregion


	}
}
