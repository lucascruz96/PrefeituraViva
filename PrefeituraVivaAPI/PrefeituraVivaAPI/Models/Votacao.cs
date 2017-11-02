using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraVivaAPI.Models
{
    public class Votacao
    {
        public int Id_vota { get; set; }
        public string Assunto { get; set; }
        public string Texto { get; set; }
        public static List<Voto> votos = new List<Voto>();
    }
}