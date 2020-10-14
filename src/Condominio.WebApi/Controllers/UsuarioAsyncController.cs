using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Condominio.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioAsyncController : ControllerBase
    {
        private readonly IUsuarioService _service;
        // GET: api/<UsuarioController>
        public UsuarioAsyncController(IUsuarioService service)
        {
            _service = service;

        }
        [HttpGet]
        public async Task<IEnumerable<UsuarioViewModel>> UsuariosAsync()
        {
            return await _service.RetornarUsuariosAsync();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
