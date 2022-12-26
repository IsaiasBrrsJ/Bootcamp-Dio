using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PraticandoENTITY_APIRest.Entity;

namespace PraticandoENTITY_APIRest.DataContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }
    }
}