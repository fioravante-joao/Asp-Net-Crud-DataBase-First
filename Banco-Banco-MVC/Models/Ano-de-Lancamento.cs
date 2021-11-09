using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banco_Banco_MVC.Models
{
    public class Ano_de_Lancamento
    {
        public int ID { get; set; }
        public DateTime Ano { get; set; }
        public int MovieId { get; set; }
    }
}