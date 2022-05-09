using HoraDoBanho.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoBanho.Domain.Services.Interfaces
{
    public interface ILoginService : IDisposable
    {
        Task<RetornoBase> ValidarLogin(LoginModel loginModel);
    }
}
