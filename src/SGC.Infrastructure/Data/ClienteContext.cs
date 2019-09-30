﻿using Microsoft.EntityFrameworkCore;
using SGC.AppCore.Entity;
using SGC.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.Data
{
   public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) :base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<Endereco> Enderecos{ get; set; }

        public DbSet<ProfissaoCliente> ProfissaoClientes{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Nomeclatura banco
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoClienteMap());

       

        }
    }
}
