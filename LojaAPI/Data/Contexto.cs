using LojaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaAPI.Data
{
    public class Contexto : DbContext
    {
        //ctor
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
