
using Mapeamento.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;



namespace Mapeamento.Data
{

    public class DB_ESTUDO : DbContext
    {
        public DB_ESTUDO()
        {

        }
        public DB_ESTUDO(DbContextOptions<DB_ESTUDO> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));




        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



        }
          
        
        
     

        public DbSet<Pessoa> TB_PESSOA { get; set; }
        public DbSet<TipoConta> TB_TIPO_CONTA { get; set; }

        public DbSet<Conta> TB_CONTA { get; set; }

        

    }
}


