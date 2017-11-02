using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraVivaAPI.Models
{
    public class Informacao
    {
        public int IdInformacao { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Assunto { get; set; }
        public string Tipo { get; set; }
    }
}