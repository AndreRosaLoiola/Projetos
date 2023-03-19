using Mapeamento.Models;
using Microsoft.EntityFrameworkCore;

namespace Mapeamento.Data
{
  
        public class DB_ESTUDO : DbContext
        {

            public DB_ESTUDO(DbContextOptions<DB_ESTUDO> options) : base(options)
            {
            }

            public DbSet<Pessoa> TB_PESSOA { get; set; }
            public DbSet<TipoConta> TB_TIPO_CONTA { get; set; }

            public DbSet<Conta> TB_CONTA { get; set; }

    }
    }


