using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrefeituraVivaAPI.Models
{
    public class VotacaoController : ApiController
    {
        public IHttpActionResult Post(Votacao votacao)
        {
            return Ok("API ONLINE");
        }
    }
}
