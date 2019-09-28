using Microsoft.EntityFrameworkCore;
using SGC.AppCore.Entity;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");

        }
    }
}
