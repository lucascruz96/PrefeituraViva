using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraVivaAPI.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
    }
}