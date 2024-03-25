using AutoMapper;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.MapperProfiles
{
    public class MapperProfile
    {
        public class EnqiryProfile : Profile
        {

            public EnqiryProfile()
            {
                CreateMap<EnquiryRequest, Enquiry>();
                CreateMap<Enquiry, EnquiryResponse>();
                CreateMap<EnquiryUpdateRequest, Enquiry>();
                
            }

        }

        public class AcademyProfile : Profile
        {

            public AcademyProfile()
            {
                CreateMap<AcademyRequest, Academy>();
                CreateMap<Academy, AcademyResponse>();
            }

        }


    }
}
