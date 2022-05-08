using HoraDoBanho.Data.Context;
using HoraDoBanho.Domain.Interfaces;
using HoraDoBanho.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoBanho.Data.Repository
{
    public class LoginRepository : BaseRepository<LoginModel>, ILoginRepository
    {
        public LoginRepository(SqlServerDbContext db) : base(db)
        {
        }

        public async Task<LoginModel> BuscarDadosUsuario(string usuario)
        {
            return await Db.Login.Where(o => o.UserName == usuario).FirstOrDefaultAsync();
        }
    }
}
