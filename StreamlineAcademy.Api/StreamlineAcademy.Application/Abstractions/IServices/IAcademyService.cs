﻿using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StreamlineAcademy.Application.RRModels.AcademyResponse;

namespace StreamlineAcademy.Application.Abstractions.IServices
{
    public interface IAcademyService
    {
        Task<ApiResponse<AcademyResponse>> RegisterAcademy(AcademyRequest request);
        Task<ApiResponse<IEnumerable<AcademyResponse>>> GetAllAcademies();

        Task<ApiResponse<AcademyResponse>> GetAcademyById(Guid id);

        Task<ApiResponse<AcademyResponse>> DeleteAcademy(Guid id);

        Task<ApiResponse<AcademyResponse>> UpdateAcademy(AcademyUpdateRequest request);

        Task<bool> IsAcademyNameUnique (string name);

        Task<bool> IsAcademyEmailUnique(string email);


    }
}
