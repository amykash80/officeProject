using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Services;
using StreamlineAcademy.Application.Shared;
using StreamlineAcademy.Domain.Enums;
using System.Runtime.InteropServices;
using static StreamlineAcademy.Application.RRModels.AcademyResponse;

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
        public async Task<ApiResponse<AcademyResponse>> RegisterAcademy(AcademyRequest request) => await academyService.RegisterAcademy(request);

        [HttpGet]
        public async Task<ApiResponse<IEnumerable<AcademyResponse>>> GetAllAcademies() => await academyService.GetAllAcademies();

        [HttpGet("{id:guid}")]
        public async Task<ApiResponse<AcademyResponse>> GetAcademyById(Guid id) => await academyService.GetAcademyById(id);

        [HttpDelete("{id:guid}")]
        public async Task<ApiResponse<AcademyResponse>> DeleteAcademy(Guid id) => await academyService.DeleteAcademy(id);

        [HttpPut]
        public async Task<ApiResponse<AcademyResponse>> UpdateAcademy(AcademyUpdateRequest model) => await academyService.UpdateAcademy(model);

        [HttpGet("check-academyname/{academyName}")]

        public async Task<IResult> IsAcadeyNameUnique(string academyName)
        {
           var isUnique= await academyService.IsAcademyNameUnique(academyName);
            return Results.Ok(isUnique);
        }

        [HttpGet("check-academyemail/{academyEmail}")]

        public async Task<IResult> IsAcademyEmailUnique(string academyEmail)
        {
            var isUnique = await academyService.IsAcademyEmailUnique(academyEmail);
            return Results.Ok(isUnique);
        }
    }
}
