using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoUm.Models;

namespace ProjetoUm.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var endereco = modelBuilder.Entity<Endereco>();

            endereco.HasKey(pk => pk.Id);

            endereco.HasOne(c => c.Cliente).WithOne(c => c.Endereco).HasForeignKey<Cliente>(c => c.EnderecoId).OnDelete(DeleteBehavior.NoAction);

            endereco.HasOne(f => f.Fornecedor).WithOne(f => f.Endereco).HasForeignKey<Fornecedor>(f => f.EnderecoId).OnDelete(DeleteBehavior.NoAction);

            endereco.HasOne(v => v.Vendedor).WithOne(v => v.Endereco).HasForeignKey<Vendedor>(v => v.EnderecoId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}