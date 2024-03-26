using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Abstractions.IServices
{
    public interface IAuthService
    {

        Task<ApiResponse<LoginResponse>> Login(LoginRequest request);
        Task<ApiResponse<string>> ChangePassword(ChangePasswordRequest model);

    }
}
