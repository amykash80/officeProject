using StreamlineAcademy.Domain.Enums;
using StreamlineAcademy.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Domain.Entities
{
    public  class SuperAdmin:BaseModel
    {
        public string Name { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string Email {  get; set; }= null!;

        public string Password { get; set; }=null!;

        public string Salt { get; set; }=null!;

        public string PhoneNumber { get; set; }=null!;

        public Enums.Enums UserRole { get; set; }

    }
}
