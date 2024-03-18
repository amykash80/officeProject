using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Services;
using StreamlineAcademy.Application.Shared;
using System.Threading.Tasks;

namespace StreamlineAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnquiryController : ControllerBase
    {
        private readonly IEnquiryService enquiryService;

        public EnquiryController(IEnquiryService enquiryService)
             
        {
            this.enquiryService = enquiryService;
        }

        [HttpPost]
        public async Task<ApiResponse<EnquiryResponse>> AddEnquiry(EnquiryRequest model) => await enquiryService.AddEnquiry(model);

        [HttpPut]

        public async Task<ApiResponse<EnquiryResponse>> UpdateEnquiry(EnquiryUpdateRequest model) => await enquiryService.UpdateEnquiry(model);

        [HttpDelete("{id:guid}")]

        public async Task<ApiResponse<EnquiryResponse>> DeleteEnquiry (Guid id) => await enquiryService.DeleteEnquiry(id);

        [HttpGet]

        public async Task<ApiResponse<IEnumerable<EnquiryResponse>>> GetAllEnquiries() => await enquiryService.GetAllEnquiries();


        [HttpGet("{id:guid}")]

        public async Task<ApiResponse<EnquiryResponse>> GetEnquiryById(Guid id) => await enquiryService.GetEnquiryById(id);


    }
}
