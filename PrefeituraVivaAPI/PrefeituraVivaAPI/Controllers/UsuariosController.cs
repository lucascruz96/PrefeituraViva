using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PrefeituraVivaAPI.Models;
using PrefeituraVivaAPI.Banco;
using System.Web.Http.Description;

namespace PrefeituraVivaAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult Get(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Cpf) || string.IsNullOrEmpty(usuario.Senha))
            {
                return NotFound();
            }
            else
            {
                if (BD.usuarios.Where(u => (u.Cpf == usuario.Cpf && u.Senha == usuario.Senha)).ToList().Count > 0)
                {
                    return Ok(BD.usuarios.Where(u => (u.Cpf == usuario.Cpf && u.Senha == usuario.Senha)).FirstOrDefault());
                }
                else
                    return BadRequest();
            }
        }
    }
}
