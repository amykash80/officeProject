using AutoMapper;
using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.Abstractions.JWT;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;
using StreamlineAcademy.Application.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository authRepository;
        private readonly IMapper mapper;
        private readonly IJwtProvider jwtProvider;

        public AuthService(IAuthRepository authRepository, IMapper mapper, IJwtProvider jwtProvider)
        {
            this.authRepository = authRepository;
            this.mapper = mapper;
            this.jwtProvider = jwtProvider;
        }
        public async Task<ApiResponse<LoginResponse>> Login(LoginRequest request)
        {
            var user = await authRepository.FirstOrDefaultAsync(x=>x.Email==request.Email);
            if (user == null)
            
                return ApiResponse<LoginResponse>.ErrorResponse("Invalid credential.");

                if((AppEncryption.HashPassword(request.Password,user.Salt)) != user.Password)
                  {
                return ApiResponse<LoginResponse>.ErrorResponse("Invalid credential.");
                  }


            //var token = jwtProvider.GenerateToken(user);
            LoginResponse response = new LoginResponse()
            {
                FullName = user.Name,
                UserRole = user.UserRole,
                Token = jwtProvider.GenerateToken(user)

            };

            return ApiResponse<LoginResponse>.SuccessResponse(response);
        }
        

        
    }


}
