using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Livraria.Models
{
    class LivroM
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public string Livron { get; set; }
        public string Autor { get; set; }
        public string Datap { get; set; }
        public string Editora { get; set; }

        public LivroM() { }

        public LivroM(string tipo, string genero, string livron, string autor, string datap, string editora)
        {
            this.Tipo = tipo;
            this.Genero = genero;
            this.Livron = livron;
            this.Autor = autor;
            this.Datap = datap;
            this.Editora = editora;
        }
    }
}
