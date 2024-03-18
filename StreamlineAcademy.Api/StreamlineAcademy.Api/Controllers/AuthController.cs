﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Services;
using StreamlineAcademy.Application.Shared;

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
        public async Task<ApiResponse<EnquiryResponse>> AddEnquiry (EnquiryRequest model) =>  await enquiryService.AddEnquiry(model);


    }
}
