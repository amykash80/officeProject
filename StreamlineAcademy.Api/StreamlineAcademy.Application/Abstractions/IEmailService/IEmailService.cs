using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Abstractions.IEmailService
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(MailSetting settings);

    }
}
