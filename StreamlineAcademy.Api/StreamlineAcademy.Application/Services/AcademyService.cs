using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;
using StreamlineAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Services
{
    public class AcademyService : IAcademyService
    {
        private readonly IAcademyRepository academyRepository;
        private readonly IAcademyDestinationRepository academyDestination;

        public AcademyService(IAcademyRepository academyRepository,
                               IAcademyDestinationRepository academyDestination)
        {
            this.academyRepository = academyRepository;
            this.academyDestination = academyDestination;
        }
        public async Task<ApiResponse<int>> Register(AcademyRegistrationRequest request)
        {
            Academy academy = new Academy() { 
            
            Name=request.AcademyRequest.Name,
            AcademyName=request.AcademyRequest.AcademyName,
            PhoneNumber=request.AcademyRequest.PhoneNumber,
            PostalCode=request.AcademyRequest.PostalCode,
            Email=request.AcademyRequest.Email,
            Address =request.AcademyRequest.Address,
            AcademyTypeId=request.AcademyRequest.AcademyTypeId

            };

           var returnVal= await academyRepository.InsertAsync(academy);
            if(returnVal>0)
            {
                List<AcademyDestinations> academyDestinations = new List<AcademyDestinations>();
                foreach (var destination in request.AcademyDestinations)
                {
                    academyDestinations.Add(new AcademyDestinations() { 
                    
                    AcademyId=academy.Id,
                    CountryId=destination.CountryId,
                    StateId=destination.StateId,
                    CityId=destination.CityId,
                    });

                }

              var res=  await academyDestination.InsertRangeAsync(academyDestinations);
                if (res > 0)
                  return ApiResponse<int>.SuccessResponse(res, "Academy Registered Successfully");
                 return ApiResponse<int>.ErrorResponse("Something Went Wrong");
            }
                 return ApiResponse<int>.ErrorResponse("Something Went Wrong");
        }
    }
}
