using StreamlineAcademy.Application.Abstractions.JWT;
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
        public string GenerateToken<T>(T model) where T : BaseModel
        {
            throw new NotImplementedException();
        }
    }
}
