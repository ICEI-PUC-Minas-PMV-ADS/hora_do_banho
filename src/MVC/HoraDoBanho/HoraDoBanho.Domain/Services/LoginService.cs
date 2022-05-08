using HoraDoBanho.Domain.Interfaces;
using HoraDoBanho.Domain.Models;
using HoraDoBanho.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoBanho.Domain.Services
{
    public class LoginService : ILoginService
    {
        public readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<RetornoBase> ValidarLogin(LoginModel model)
        {
            LoginModel loginRepository = await _loginRepository.BuscarDadosUsuario(model.UserName);

            if (loginRepository != null && loginRepository.Password == GerarHashMd5(model.Password))
            {
                return new RetornoBase() { Sucesso = true };
            }
            else
            {
                return new RetornoBase() { Sucesso = false, MsgRetorno = "E-mail ou senha inválidos" };
            }
        }

        public async Task InserirLoginTeste()
        {
            LoginModel loginRepository = await _loginRepository.BuscarDadosUsuario("crislaine.silva@sga.pucminas.br");

            if (loginRepository == null)
            {
                await _loginRepository.IncluiAsync(new LoginModel()
                {
                    IdUsuario = 0,
                    Password = GerarHashMd5("123456"),
                    UserName = "crislaine.silva@sga.pucminas.br"
                });
            }
        }

        public void Dispose()
        {
            _loginRepository?.Dispose();
        }

        public static string GerarHashMd5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
