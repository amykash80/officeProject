using StreamlineAcademy.Application.Abstractions.JWT;
using StreamlineAcademy.Domain.Entities;
using StreamlineAcademy.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Infrastructure.JWT
{
    public class JwtProvider : IJwtProvider
    {
        

        public string GenerateToken(User user)
        {
            throw new NotImplementedException();
        }
    }
}
