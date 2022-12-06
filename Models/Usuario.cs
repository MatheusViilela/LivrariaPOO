using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Usuario(string nome, string cpf, string telefone, string email)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}
