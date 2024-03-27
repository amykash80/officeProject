using AutoMapper;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Asn1.Cmp;
using StreamlineAcademy.Application.Abstractions.Identity;
using StreamlineAcademy.Application.Abstractions.IEmailService;
using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;
using StreamlineAcademy.Application.Utils;
using StreamlineAcademy.Domain.Entities;
using StreamlineAcademy.Domain.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static StreamlineAcademy.Application.RRModels.AcademyResponse;
using static StreamlineAcademy.Application.Shared.APIMessages;

namespace StreamlineAcademy.Application.Services
{
    public class AcademyService : IAcademyService
    {
        private readonly IAcademyRepository academyRepository;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private readonly IEnquiryService enquiryService;
		private readonly IEmailService emailService;
		private readonly IContextService contextService;

		public AcademyService(IAcademyRepository academyRepository,
                               IMapper mapper ,
                               IUserRepository userRepository ,
                               IEnquiryService enquiryService,
                               IEmailService emailService,
                               IContextService contextService)
        {
            this.academyRepository = academyRepository;
            this.mapper = mapper;
            this.userRepository = userRepository;
            this.enquiryService = enquiryService;
			this.emailService = emailService;
			this.contextService = contextService;
		}

        public async Task<ApiResponse<AcademyResponse>> GetAcademyById(Guid id)
        {
            if(await academyRepository.GetByIdAsync(x => x.Id == id) is null)
                return ApiResponse<AcademyResponse>.ErrorResponse("No Academy Found",HttpStatusCodes.NotFound);

            return ApiResponse<AcademyResponse>.SuccessResponse(mapper.Map<AcademyResponse>(await academyRepository.GetAcademyById(id)));
        }

        public async Task<ApiResponse<IEnumerable<AcademyResponse>>> GetAllAcademies()
        {
            var returnVal = await academyRepository.GetallAcademies();
            if (returnVal is not null)
                return ApiResponse<IEnumerable<AcademyResponse>>.SuccessResponse(returnVal.OrderBy(_=>_.AcademyName),$"Found {returnVal.Count()} Academies");
                return ApiResponse<IEnumerable<AcademyResponse>>.ErrorResponse("No Academy Found",HttpStatusCodes.NotFound);
        }


        public async Task<ApiResponse<AcademyResponse>> RegisterAcademy(AcademyRequest request)
        {

            var existingAcademy = await academyRepository.GetByIdAsync(x => x.AcademyName == request.AcademyName);
            if (existingAcademy is not  null)
                return ApiResponse<AcademyResponse>.ErrorResponse("Academy already registered",HttpStatusCodes.Conflict);

            var existingEmail = await userRepository.FirstOrDefaultAsync(x => x.Email == request.Email);
            if (existingEmail is not null)
              return ApiResponse<AcademyResponse>.ErrorResponse("Academy with this email already registered",HttpStatusCodes.Conflict); 

            var user = mapper.Map<User>(request);
            user.Salt = AppEncryption.GenerateSalt();
            user.Password = AppEncryption.HashPassword(request.Password, user.Salt);
            user.UserRole = UserRole.AcademyAdmin;
            var returnVal = await userRepository.InsertAsync(user);
            if (returnVal > 0)
            {
                var academy=mapper.Map<Academy>(request);
                academy.Id = user.Id;
                var result = await academyRepository.InsertAsync(academy);
                if (result > 0)
				{

				
					var updateStatusResponse = await academyRepository.UpdateRegistrationStatus(academy.Id, RegistrationStatus.Approved);
                    var res = await academyRepository.GetAcademyById(academy.Id);
                    return ApiResponse<AcademyResponse>.SuccessResponse(mapper.Map<AcademyResponse>(res));

                }

                return ApiResponse<AcademyResponse>.ErrorResponse("something went Wrong", HttpStatusCodes.BadRequest);

            }
            return ApiResponse<AcademyResponse>.ErrorResponse("something went Wrong", HttpStatusCodes.BadRequest);



        }

        public async Task<ApiResponse<AcademyResponse>> DeleteAcademy(Guid id)
        {

            var existingAcademy = await academyRepository.GetByIdAsync(x => x.Id == id);
            if (existingAcademy is null)
                return ApiResponse<AcademyResponse>.ErrorResponse("Academy Not Found",HttpStatusCodes.NotFound);

            var result = await academyRepository.DeleteAsync(existingAcademy);
            if (result > 0)
            {

                var returnVal=await academyRepository.GetAcademyById(existingAcademy.Id);
                return ApiResponse<AcademyResponse>.SuccessResponse(returnVal, "Enquiry Deleted Successfullly");
            }

            return ApiResponse<AcademyResponse>.ErrorResponse("Something Went Wrong, please try again", HttpStatusCodes.InternalServerError);

        }

        

        public async Task<ApiResponse<AcademyResponse>> UpdateAcademy(AcademyUpdateRequest request)
        {
            var existAcademy = await academyRepository.GetByIdAsync(x => x.Id == request.Id);
            if (existAcademy is null)
                return ApiResponse<AcademyResponse>.ErrorResponse("Academy not found", HttpStatusCodes.NotFound);

            var academy = mapper.Map(request, existAcademy);
            var updateAcademy = await academyRepository.UpdateAsync(existAcademy);
            if (updateAcademy is > 0)
                return ApiResponse<AcademyResponse>.SuccessResponse(mapper.Map<AcademyResponse>(academy), "Academy Updated Successfullly");
            return ApiResponse<AcademyResponse>.ErrorResponse("Something Went Wrong,please try again", HttpStatusCodes.InternalServerError);
        }

        public async Task<bool> IsAcademyNameUnique(string name)
        {
            return await academyRepository.FirstOrDefaultAsync(x => x.AcademyName == name) == null;

        }


        public async Task<bool> IsAcademyEmailUnique(string email)
        {
            return await userRepository.FirstOrDefaultAsync(x => x.Email == email) == null;

        }
    }
}
