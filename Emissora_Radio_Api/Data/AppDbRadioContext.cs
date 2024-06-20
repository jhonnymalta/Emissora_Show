using Emissora_Radio_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Emissora_Radio_Api.Data
{
    public class AppDbRadioContext : DbContext
    {
        public AppDbRadioContext(DbContextOptions options) : base(options) {}

        public DbSet<Programa> Programas { get; set; }
    }
}
