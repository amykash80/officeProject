using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Domain.Shared
{
    public  class BaseModel
    {
        public Guid Id { get; set; }   
        
        public DateTimeOffset CreatedOn { get; set; }

    }
}
