using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;
using StreamlineAcademy.Domain.Entities;
using StreamlineAcademy.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StreamlineAcademy.Persistence.Repositories
{
    public class AcademyDestinationsRepository : BaseRepository<AcademyDestinations>, IAcademyDestinationRepository
    {

        public AcademyDestinationsRepository(StreamlineAcademyDbContet context):base(context)
        {
            
        }

    }
}
    

