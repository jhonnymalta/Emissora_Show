using Emissora_Tv_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Emissora_Tv_Api.Data
{
    public class AppDbTvContext : DbContext
    {
        public AppDbTvContext(DbContextOptions<AppDbTvContext> options) : base(options){}

        public DbSet<Programa> Programas { get; set; }

       
    }
}
