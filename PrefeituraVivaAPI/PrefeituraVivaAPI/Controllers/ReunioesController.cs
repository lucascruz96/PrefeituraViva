using PrefeituraVivaAPI.Banco;
using PrefeituraVivaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PrefeituraVivaAPI.Controllers
{
    public class ReunioesController : ApiController
    {
        [ResponseType(typeof(List<Reuniao>))]
        public IHttpActionResult Get()
        {
            return Ok(BD.reunioes);
        }
    }
}
