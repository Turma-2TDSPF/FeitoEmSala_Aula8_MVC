using Microsoft.EntityFrameworkCore;
using Reserva.Models;

namespace Reserva.Infra.Context
{
    public class ReservaContext : DbContext
    {
        public ReservaContext() { }

        public ReservaContext(DbContextOptions<ReservaContext> options): base(options) { 
        }

        public DbSet<ReservaModel> Reserva { get; set; }

    }
}
