using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;

namespace StreamlineAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademyController : ControllerBase
    {
        private readonly IAcademyService academyService;

        public AcademyController(IAcademyService academyService)
        {
            this.academyService = academyService;
        }

        public async Task<ApiResponse<int>> RegisterAcademy(AcademyRegistrationRequest request)
        {
           return await academyService.Register(request);
        }
    }
}
