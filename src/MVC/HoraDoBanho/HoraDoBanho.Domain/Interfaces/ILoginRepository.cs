using HoraDoBanho.Domain.Entity;
using HoraDoBanho.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoBanho.Domain.Interfaces
{
    public interface ILoginRepository : IAsyncRepository<LoginEntity>
    {
        Task<LoginEntity> BuscarDadosUsuario(string usuario);
    }
}
