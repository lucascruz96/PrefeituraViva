using PrefeituraVivaAPI.Banco;
using PrefeituraVivaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrefeituraVivaAPI.Controllers
{
    public class PresencaController : ApiController
    {
        public IHttpActionResult Post(Presenca presenca)
        {
            BD.reunioes[BD.reunioes.FindIndex(r => r.Id_Reuniao == presenca.Reuniao_Id_Reuniao)].presentes.Add(presenca.Usuario_Id_usuario);

            return Ok("Presença confirmada");
        }
    }
}
