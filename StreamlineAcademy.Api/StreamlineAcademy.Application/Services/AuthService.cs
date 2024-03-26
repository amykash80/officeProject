using AutoMapper;
using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Services
{
    //public class AuthService : IAuthService
    //{
    //    private readonly IAuthRepository authRepository;
    //    private readonly IMapper mapper;

    //    public AuthService(IAuthRepository authRepository,IMapper mapper)
    //    {
    //        this.authRepository = authRepository;
    //        this.mapper = mapper;
    //    }
    //    public async Task<ApiResponse<LoginResponse>> Login(LoginRequest request)
    //    {
    //        var user = await authRepository.FirstOrDefaultAsync(x => x.Email == request.Email);
    //        if (user == null)
    //        {
    //            return ApiResponse<LoginResponse>.ErrorResponse("Credential required.");
    //        }
    //    }
    //}
}
