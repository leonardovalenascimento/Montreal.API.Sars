using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montreal.API.Sars.Models
{
    public class DataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath
                (Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration
                ["ConnectionString:DefaultConnection"]);
        }

        public DbSet <TipoDocumentoKofax> TipoDocumentoKofax { get; set; }

    }
}
