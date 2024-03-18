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
    public class EnquiryService : IEnquiryService
    {
        private readonly IEnquiryRepository enquiryrepository;
        private readonly IMapper mapper;

        public EnquiryService(IEnquiryRepository enquiryrepository,IMapper mapper)
        {
            this.enquiryrepository = enquiryrepository;
            this.mapper = mapper;
        }

       
        public async Task<ApiResponse<EnquiryResponse>> AddEnquiry(EnquiryRequest request)
        {
            if( await enquiryrepository.FirstOrDefaultAsync(x=>x.Name== request.Name) is not null)
                return ApiResponse<EnquiryResponse>.ErrorResponse("Name  already Exists", HttpStatusCodes.Conflict);

            if (await enquiryrepository.FirstOrDefaultAsync(x => x.Email == request.Email ) is not null)
                return ApiResponse<EnquiryResponse>.ErrorResponse(" Email already Exists", HttpStatusCodes.Conflict);

            var enquiry = mapper.Map<Enquiry>(request);

            var res = await enquiryrepository.InsertAsync(enquiry);

            if (res > 0)
                return ApiResponse<EnquiryResponse>.SuccessResponse(mapper.Map<EnquiryResponse>(enquiry), "Enquiry Added Successfully", HttpStatusCodes.Created);
                return ApiResponse<EnquiryResponse>.ErrorResponse("Something Went Wrong,please try again",HttpStatusCodes.InternalServerError);


            
        }

        public async Task<ApiResponse<IEnumerable<EnquiryResponse>>> GetAllEnquiries()
        {
            var enquiryList=await enquiryrepository.GetAllAsync();
            if(enquiryList.Any())
                return ApiResponse<IEnumerable<EnquiryResponse>>.SuccessResponse(mapper.Map<IEnumerable<EnquiryResponse>>(enquiryList));
                return ApiResponse<IEnumerable<EnquiryResponse>>.ErrorResponse("No Enquiry Found",HttpStatusCodes.NotFound);
        }

        public async Task<ApiResponse<EnquiryResponse>> GetEnquiryById(Guid id)
        {
            if (await enquiryrepository.GetByIdAsync(x=>x.Id==id) is null)
                return ApiResponse<EnquiryResponse>.ErrorResponse("No Enquiry Found", HttpStatusCodes.NotFound);

            var enquiry = await enquiryrepository.GetByIdAsync(x=>x.Id == id);

            if (enquiry is not null)
                return ApiResponse<EnquiryResponse>.SuccessResponse(mapper.Map<EnquiryResponse>(enquiry));
            return ApiResponse<EnquiryResponse>.ErrorResponse("Something Went Wrong,please try again", HttpStatusCodes.InternalServerError);


        }
    }
}
