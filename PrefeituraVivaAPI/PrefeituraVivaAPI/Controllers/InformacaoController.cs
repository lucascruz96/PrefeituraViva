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
    public class InformacaoController : ApiController
    {
        public IHttpActionResult Post(Informacao informacao)
        {
            BD.informacoes.Add(informacao);

            return Ok($"{informacao.Tipo} cadastrada com sucesso.");
        }
    }
}
