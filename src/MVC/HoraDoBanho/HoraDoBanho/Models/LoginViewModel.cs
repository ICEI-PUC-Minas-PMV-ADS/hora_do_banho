namespace HoraDoBanho.Models
{
    public class LoginViewModel : BaseRetorno
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ManterConectado { get; set; }
    }
}
