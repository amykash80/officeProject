using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Services;
using StreamlineAcademy.Application.Shared;

namespace StreamlineAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
             
        {
            this.authService = authService;
        }

        [HttpPost("Enquiry")]
        public async Task<ApiResponse<EnquiryResponse>> AddEnquiry (EnquiryRequest model) =>  await authService.AddEnquiry(model);


    }
}
