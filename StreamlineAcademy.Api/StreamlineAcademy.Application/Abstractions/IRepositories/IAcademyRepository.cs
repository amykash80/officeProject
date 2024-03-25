using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Domain.Entities;
using StreamlineAcademy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Abstractions.IRepositories
{
    public interface IAcademyRepository:IBaseRepository<Academy>
    {
        Task<IEnumerable<AcademyResponse>> GetallAcademies();
        Task<AcademyResponse> GetAcademyById(Guid id);
        Task<bool> UpdateRegistrationStatus(Guid id, RegistrationStatus status);

        


    }
}
