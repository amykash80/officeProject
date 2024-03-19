using Microsoft.EntityFrameworkCore;
using StreamlineAcademy.Application.Utils;
using StreamlineAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StreamlineAcademy.Domain.Enums;
using System.Threading.Tasks;

namespace StreamlineAcademy.Persistence.Data
{
    public class StreamlineAcademyDbContet:DbContext
    {
        public StreamlineAcademyDbContet(DbContextOptions<StreamlineAcademyDbContet> options):base(options) 
        {
           
        }

        public DbSet<Enquiry> Enquiries { get; set; }

       
        public DbSet<SuperAdmin> SuperAdmins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Enquiry>().HasIndex(x => x.Name);
            modelBuilder.Entity<Enquiry>().HasIndex(y => y.Email);
            var Passwordsalt=AppEncryption.GenerateSalt();
            modelBuilder.Entity<SuperAdmin>().HasData(

                    new SuperAdmin() {
                    Id = Guid.NewGuid(),
                    Name = "Ram",
                    Email = "ram@gmail.com",
                    UserName = "superadmin@123",
                    Salt = Passwordsalt,
                    Password = AppEncryption.HashPassword("superadmin", Passwordsalt),
                    PhoneNumber = "7267636376",
                    UserRole = UserRole.SuperAdmin,
                   CreatedOn = DateTime.Now,

                }

            );
        }

        
    }
}
