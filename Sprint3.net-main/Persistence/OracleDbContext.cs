using Microsoft.EntityFrameworkCore;
using Sprint3.Models;

namespace Sprint3.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<ComportamentoNegocios> ComportamentoNegocios { get; set; }
        public DbSet<TendenciasGastos> TendenciasGastos { get; set; }
        public DbSet<DesempenhoFinanceiro> DesempenhoFinanceiro { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
        {
        }

    }

}
