using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Condominio.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        // GET: api/<UsuarioController>
        public UsuarioController(IUsuarioService service)
        {
            _service = service;

        }

        [HttpGet]
        public async Task<IActionResult> UsuariosAsync()
        {
            try
            {
                var retorno = await _service.RetornarUsuariosAsync();
                if (!retorno.Any())
                    return BadRequest(new RetornoViewModel { MsgRetorno = "Nenhum registro encontrado", ErrosRetorno = new List<string> { "01" } });
                return Ok(retorno);
            }
            catch (Exception e)
            {
                return BadRequest(new RetornoViewModel { MsgRetorno = e.Message.ToString()});
            }
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var retorno = await _service.LogarAsync(id);
                if (retorno == null)
                    return BadRequest(new RetornoViewModel { MsgRetorno = "Nenhum registro encontrado", ErrosRetorno = new List<string> { "01" } });
                return Ok(retorno);
            }
            catch (Exception e)
            {
                return BadRequest(new RetornoViewModel { MsgRetorno = e.Message.ToString()});
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioViewModel usuario)
        {
            try
            {
                var result = await _service.RegistrarAsync(usuario);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest( new RetornoViewModel { MsgRetorno = e.Message.ToString()});
            }
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] UsuarioViewModel value)
        {
            try
            {                
                var result = await _service.AtualizarAsync(value);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new RetornoViewModel { MsgRetorno = e.Message.ToString()});
            }
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task <IActionResult>Delete(string id)
        {
            try
            {
                var result = await _service.ApagarAsync(id);
                return Ok(result);
            }
            catch(Exception e) 
            {
                return BadRequest(new RetornoViewModel { MsgRetorno = e.Message.ToString()});
            }
            
        }
    }
}
