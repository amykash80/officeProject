using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Domain.Entities;
using StreamlineAcademy.Domain.Enums;
using StreamlineAcademy.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StreamlineAcademy.Persistence.Repositories
{
    public class AcademyRepository:BaseRepository<Academy>,IAcademyRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public AcademyRepository(StreamlineAcademyDbContet context,IConfiguration configuration):base(context) 
        {
            _configuration = configuration;
            _connectionString = configuration.GetConnectionString("StreamlineAcademyDbContet")!;
        }
        #region dapper methods

        public async Task<AcademyResponse> GetAcademyById(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                SELECT a.Id, a.AcademyName, U.Email, U.PhoneNumber,U.Name as AcademyAdmin ,U.PostalCode,U.Address,at.Name as AcademyType,
                       c.CountryName, s.StateName, ct.CityName,U.UserRole
                FROM Academies a
                INNER JOIN Users U ON a.Id=U.Id
                INNER JOIN AcademyTypes at ON a.AcademyTypeId = at.Id
                INNER JOIN Countries c ON a.CountryId = c.Id
                INNER JOIN States s ON a.StateId = s.Id
                INNER JOIN Cities ct ON a.CityId = ct.Id

                WHERE
                 a.Id = @Id";

                var returnVal= await connection.QueryFirstOrDefaultAsync<AcademyResponse>(query,new {Id=id});
                return returnVal!;


            }
        }

        public async Task<IEnumerable<AcademyResponse>> GetallAcademies()
        {


            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                SELECT a.Id, a.AcademyName, U.Email, U.PhoneNumber,U.Name as AcademyAdmin ,U.PostalCode,U.Address,at.Name as AcademyType,
                       c.CountryName, s.StateName, ct.CityName,U.UserRole
                FROM Academies a
                INNER JOIN Users U ON a.Id=U.Id
                INNER JOIN AcademyTypes at ON a.AcademyTypeId = at.Id
                INNER JOIN Countries c ON a.CountryId = c.Id
                INNER JOIN States s ON a.StateId = s.Id
                INNER JOIN Cities ct ON a.CityId = ct.Id";

                return await connection.QueryAsync<AcademyResponse>(query);


            }

        }

        public async Task<bool> UpdateRegistrationStatus(Guid id, RegistrationStatus status)
        {
            using (var connection = new SqlConnection(_connectionString))
            {


            string sql = @"UPDATE Enquiries
                        SET RegistrationStatus = @Status
                         WHERE Id = @id";

            int rowsAffected = await connection.ExecuteAsync(sql, new { Id = id, Status = status });

            return rowsAffected > 0;

            }

        }

        #endregion
    }
}
