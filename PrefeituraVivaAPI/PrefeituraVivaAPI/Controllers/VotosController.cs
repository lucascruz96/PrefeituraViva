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
    public class VotosController : ApiController
    {
        public IHttpActionResult Post(Voto voto)
        {
            BD.votacoes[BD.votacoes.FindIndex(v => v.Id_vota == voto.Votacao_Id_Vota)].Votos.Add(voto);

            return Ok("Voto adicionado");
        }
    }
}
