using AutoMapper;
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
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository authRepository;
        private readonly IMapper mapper;

        public AuthService(IAuthRepository authRepository,
                            IMapper mapper)
        {
            this.authRepository = authRepository;
            this.mapper = mapper;
        }
        public async Task<ApiResponse<EnquiryResponse>> AddEnquiry(EnquiryRequest request)
        {
            var nameExists = await authRepository.FirstOrDefaultAsync(x=>x.Name== request.Name);
            if(nameExists is not null)
                return ApiResponse<EnquiryResponse>.ErrorResponse("Name already Exists", HttpStatusCodes.BadRequest);

            var enquiry = mapper.Map<Enquiry>(request);
            enquiry.Id=Guid.NewGuid();

            var res = await authRepository.InsertAsync(enquiry);
            if (res > 0)
                return ApiResponse<EnquiryResponse>.SuccessResponse(mapper.Map<EnquiryResponse>(enquiry), "Enquiry Added Successfully", HttpStatusCodes.Created);
                return ApiResponse<EnquiryResponse>.ErrorResponse("Something Went Wrong,try again",HttpStatusCodes.BadRequest);


            
        }
    }
}
