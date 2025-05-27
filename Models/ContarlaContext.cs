using Contarla_Para_Vivir_PNT.Models;
using Microsoft.EntityFrameworkCore;

namespace ContarlaParaVivir.Models
{
    public class ContarlaContext : DbContext
    {
        public ContarlaContext(DbContextOptions<ContarlaContext> options)
            : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<DosisLiteraria> DosisLiterarias { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
