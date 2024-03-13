using Microsoft.EntityFrameworkCore;
using StreamlineAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Persistence.Data
{
    public class StreamlineAcademyDbContet:DbContext
    {
        public StreamlineAcademyDbContet(DbContextOptions<StreamlineAcademyDbContet> options):base(options) 
        {
           
        }

        public DbSet<Enquiry> Enquiries { get; set; }
    }
}
