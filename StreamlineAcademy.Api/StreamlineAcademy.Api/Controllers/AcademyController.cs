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

        [HttpPost]

        public async Task<ApiResponse<AcademyResponse>> RegisterAcademy(AcademyRequest request) => await academyService.Register(request);



        [HttpGet]

        public async Task<ApiResponse<IEnumerable<AcademyResponse>>> GetAllAcademies() => await academyService.GetAllAcademies();
    }
}
