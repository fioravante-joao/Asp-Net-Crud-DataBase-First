using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Banco_Banco_MVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        //Ao alterar uma tabela ou criar outra tabela, fazer a migration para atualizar o banco de dados link abaixo:
        //http://go.microsoft.com/fwlink/?LinkId=238269

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Ano_de_Lancamento> Ano_de_Lancamentos { get; set; }
    }
}