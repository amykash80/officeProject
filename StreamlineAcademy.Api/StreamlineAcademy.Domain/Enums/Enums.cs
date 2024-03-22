using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Domain.Enums
{
    public enum UserRole : byte
    {
        SuperAdmin = 1,
        AcademyAdmin = 2,
        Instructoe = 3,
        Student = 4,
    }

    public enum RegistrationStatus : byte
    {

     Pending = 1,
     Approved = 2,
     Rejected = 3,
    
    }

    public enum Module : byte
    {
        SuperAdmin = 1,
        AcademyAdmin = 2,
        Instructor = 3,
        Student = 4,

    }


}
