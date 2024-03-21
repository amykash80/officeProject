using AutoMapper;
using Microsoft.Extensions.Configuration;
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
        private readonly IMapper mapper;

        public AcademyService(IAcademyRepository academyRepository,
                               IMapper mapper)
        {
            this.academyRepository = academyRepository;
            this.mapper = mapper;
        }

        public async Task<ApiResponse<IEnumerable<AcademyResponse>>> GetAllAcademies()
        {
            var returnVal = await academyRepository.GetallAcademies();
            if (returnVal is not null)
                return ApiResponse<IEnumerable<AcademyResponse>>.SuccessResponse(returnVal,$"Found {returnVal.Count()} Academies");
                return ApiResponse<IEnumerable<AcademyResponse>>.ErrorResponse("No Academy Found",HttpStatusCodes.NotFound);
        }

        public async Task<ApiResponse<AcademyResponse>> Register(AcademyRequest request)
        {

            var academy = mapper.Map<Academy>(request);

            var returnVal = await academyRepository.InsertAsync(academy);

            if (returnVal > 0)
             return ApiResponse<AcademyResponse>.SuccessResponse(new AcademyResponse());
             return ApiResponse<AcademyResponse>.ErrorResponse("Somethoing went Wrong");
            
        }
    }
}
