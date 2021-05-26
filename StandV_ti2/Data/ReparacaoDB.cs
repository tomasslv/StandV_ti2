using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StandV_ti2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandV_ti2.Data
{

    /// <summary>
    /// esta classe representa a Base de Dados a ser utilizada neste projeto
    /// </summary>
    public class ReparacaoDB : IdentityDbContext
    {
        public ReparacaoDB(DbContextOptions<ReparacaoDB> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // insert DB seed



        }

        //Representar as Tabelas da BD
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Gestores> Gestores { get; set; }
        public DbSet<Reparacoes> Reparacoes { get; set; }
        public DbSet<ReparFunc> ReparFunc { get; set; }
        public DbSet<Veiculos> Veiculos { get; set; }
        public DbSet<Fotos> Fotos { get; set; }


    }
}
