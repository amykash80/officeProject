﻿using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Domain.Entities;
using StreamlineAcademy.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public async Task<IEnumerable<AcademyResponse>> GetallAcademies()
        {


            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                SELECT a.AcademyName, a.Email, a.PhoneNumber,a.PostalCode,a.Id,a.Address,at.Name,
                       c.CountryName, s.StateName, ct.CityName
                FROM Academies a
                INNER JOIN AcademyTypes at ON a.AcademyTypeId = at.Id
                INNER JOIN Countries c ON a.CountryId = c.Id
                INNER JOIN States s ON a.StateId = s.Id
                INNER JOIN Cities ct ON a.CityId = ct.Id";

                return await connection.QueryAsync<AcademyResponse>(query);


            }

        }
    }
}
