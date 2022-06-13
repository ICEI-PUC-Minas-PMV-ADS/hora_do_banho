using Microsoft.EntityFrameworkCore;

namespace app_hora_do_banho.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }

}
