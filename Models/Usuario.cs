using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Livraria.Models
{
    class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario() { }

        public Usuario(string nome, string cpf, string telefone, string email, string senha)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
        }
        public Usuario(string nome, string cpf, string email, string senha)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.Senha = senha;
        }
    }
}
