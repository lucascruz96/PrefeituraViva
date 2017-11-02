using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrefeituraVivaAPI.Models
{
    public class Reuniao
    {
        public int Id_Reuniao { get; set; }
        public string Endereco { get; set; }
        public string Tema { get; set; }
        public string Texto { get; set; }
        public DateTime Horario { get; set; }
        public List<int> presentes = new List<int>();
    }
}