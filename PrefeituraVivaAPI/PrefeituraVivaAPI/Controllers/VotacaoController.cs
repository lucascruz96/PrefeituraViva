﻿using PrefeituraVivaAPI.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PrefeituraVivaAPI.Models
{
    public class VotacaoController : ApiController
    {
        [ResponseType(typeof(List<Votacao>))]
        public IHttpActionResult Get()
        {
            return Ok(BD.votacoes);
        }
    }
}
