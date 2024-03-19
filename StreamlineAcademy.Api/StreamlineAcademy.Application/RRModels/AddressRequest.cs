using StreamlineAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.RRModels
{
    public class CountryRequest
    {
        public string CountryName { get; set; } = null!;
       
    }
    public class CountryResponse : CountryRequest
    {
        public Guid? Id { get; set; }

    }
    public class StateRequest
    {
        public string StateName { get; set; } = null!;
        public Guid? CountryId { get; set; }

    }
    public class StateResponse : StateRequest
    {
        public Guid Id { get; set; }
       


    }
    public class CityRequest
    {
        public string CityName { get; set; } = null!;
        public Guid? StateId { get; set; }
    }
    public class CityResponse : CountryRequest
    {
        public Guid Id { get; set; }
        
    }

}
