using CrudFinal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CrudFinal.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contato { get; set; }

    }
}
