using AutoMapper;
using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.Shared;
using StreamlineAcademy.Domain.Entities;
using StreamlineAcademy.Domain.Enums;
using StreamlineAcademy.Domain.Models.Requests;
using StreamlineAcademy.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Services
{
    public class EnquiryService : IEnquiryService
    {
        private readonly IEnquiryRepository enquiryrepository;
        private readonly IMapper mapper; 
        public EnquiryService(IEnquiryRepository enquiryrepository,IMapper mapper)
        {
            this.enquiryrepository = enquiryrepository;
            this.mapper = mapper;
        }

       
        public async Task<ApiResponse<EnquiryResponseModel>> AddEnquiry(EnquiryRequestModel request)
        {
            if( await enquiryrepository.FirstOrDefaultAsync(x=>x.Name== request.Name) is not null)
                return ApiResponse<EnquiryResponseModel>.ErrorResponse("Name  already Exists", HttpStatusCodes.Conflict.ToString());

            if (await enquiryrepository.FirstOrDefaultAsync(x => x.Email == request.Email ) is not null)
                return ApiResponse<EnquiryResponseModel>.ErrorResponse(" Email already Exists", HttpStatusCodes.Conflict.ToString());

            var enquiry = mapper.Map<Enquiry>(request); 
            var res = await enquiryrepository.InsertAsync(enquiry); 
            if (res > 0)
                return ApiResponse<EnquiryResponseModel>.SuccessResponse(mapper.Map<EnquiryResponseModel>(enquiry), "Enquiry Added Successfully", HttpStatusCodes.Created.ToString());
                return ApiResponse<EnquiryResponseModel>.ErrorResponse("Something Went Wrong,please try again",HttpStatusCodes.InternalServerError.ToString()); 
        }

        public async Task<ApiResponse<EnquiryResponseModel>> UpdateEnquiry(EnquiryUpdateRequest request)
        {
            var result = await enquiryrepository.GetByIdAsync(x => x.Id == request.Id); 
            if(result is null)
            return ApiResponse<EnquiryResponseModel>.ErrorResponse("Enquiry not found", HttpStatusCodes.NotFound.ToString());

            var enquiry = mapper.Map(request,result); 
            var returnVal=  await enquiryrepository.UpdateAsync(enquiry); 
            if (returnVal is > 0)
            return ApiResponse<EnquiryResponseModel>.SuccessResponse(mapper.Map<EnquiryResponseModel>(enquiry),"Enquiry Updated Successfullly");
            return ApiResponse<EnquiryResponseModel>.ErrorResponse("Something Went Wrong,please try again", HttpStatusCodes.InternalServerError.ToString()); 
        }

        public  async Task<ApiResponse<EnquiryResponseModel>> DeleteEnquiry(Guid id)
        { 
            var existingEnquiry = await enquiryrepository.GetByIdAsync(x => x.Id == id);
            if (existingEnquiry is null)
                return ApiResponse<EnquiryResponseModel>.ErrorResponse("Enquiry Not Found");
           
            var result = await enquiryrepository.DeleteAsync(existingEnquiry);
            if (result is > 0)
            {
                var deleteResponse = mapper.Map<EnquiryResponseModel>(existingEnquiry);
                return ApiResponse<EnquiryResponseModel>.SuccessResponse(deleteResponse, "Enquiry Deleted Successfullly");
            }
            return ApiResponse<EnquiryResponseModel>.ErrorResponse("Something Went Wrong,please try again", HttpStatusCodes.InternalServerError.ToString()); 
        }

        public async Task<ApiResponse<IEnumerable<EnquiryResponseModel>>> GetAllEnquiries()
        {
            var enquiryList = await enquiryrepository.GetAllAsync();
            if(enquiryList.Any())
                return ApiResponse<IEnumerable<EnquiryResponseModel>>.SuccessResponse(mapper.Map<IEnumerable<EnquiryResponseModel>>(enquiryList.OrderBy(x=>x.Name)),$"Found {enquiryList.Count()} Enquiries");
                return ApiResponse<IEnumerable<EnquiryResponseModel>>.ErrorResponse("No Enquiry Found",HttpStatusCodes.NotFound.ToString());
        }

        public async Task<ApiResponse<EnquiryResponseModel>> GetEnquiryById(Guid id)
        {
            if (await enquiryrepository.GetByIdAsync(x => x.Id == id) is null)
                return ApiResponse<EnquiryResponseModel>.ErrorResponse("Enquiry Not Found");

            return ApiResponse<EnquiryResponseModel>.SuccessResponse(mapper.Map<EnquiryResponseModel>(await enquiryrepository.GetByIdAsync(x => x.Id == id)));
        }

        public async Task<bool> IsEnquiryEmailUnique(string email)
        {
            return await enquiryrepository.FirstOrDefaultAsync(x => x.Email == email) == null;
        }
    }
}
