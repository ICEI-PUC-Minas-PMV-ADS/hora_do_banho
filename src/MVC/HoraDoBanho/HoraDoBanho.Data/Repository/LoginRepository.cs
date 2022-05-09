using HoraDoBanho.Data.Context;
using HoraDoBanho.Domain.Interfaces;
using HoraDoBanho.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoBanho.Data.Repository
{
    public class LoginRepository : BaseRepository<LoginEntity>, ILoginRepository
    {
        public LoginRepository(SqlServerDbContext db) : base(db)
        {
        }

        public async Task<LoginEntity> BuscarDadosUsuario(string usuario)
        {
            return await Db.Login.Where(o => o.userName == usuario).FirstOrDefaultAsync();
        }
    }
}
