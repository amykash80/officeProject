using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.RRModels
{
    public class EnquiryRequest // Clint request model
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }

    public class EnquiryResponse:EnquiryRequest // to send response to clint
    {
        public Guid Id { get; set; }
        
    }

    public class EnquiryUpdateRequest:EnquiryResponse  // to update  response 
    {

    }
}
