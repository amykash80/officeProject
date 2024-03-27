using StreamlineAcademy.Domain.Entities;
using StreamlineAcademy.Domain.Enums;
using StreamlineAcademy.Domain.Models.Requests;
using StreamlineAcademy.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Abstractions.IRepositories
{
    public interface IAcademyRepository:IBaseRepository<Academy>
    {
        Task<IEnumerable<AcademyResponseModel>> GetallAcademies();
        Task<AcademyResponseModel> GetAcademyById(Guid id);
        Task<bool> UpdateRegistrationStatus(Guid id, RegistrationStatus status); 
    }
}
