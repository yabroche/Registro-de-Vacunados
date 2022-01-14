using Microsoft.EntityFrameworkCore;
using Registro_de_Vacunados.Entities;

namespace Registro_de_Vacunados.Services
{
    public class VacunadosDbContext : DbContext
    {
        public VacunadosDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RvacunadosTab> RvacunadosTab { get; set; }
    }

}
