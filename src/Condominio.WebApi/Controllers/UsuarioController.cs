using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Entidades;
using Condominio.WebApi.JWT;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IMapper _mapper;
        // GET: api/<UsuarioController>
        public UsuarioController(IUsuarioService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles ="admin")]
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
                return BadRequest(new RetornoViewModel { MsgRetorno = e.Message.ToString() });
            }

        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var retorno = await _service.ConsultarUsuario(id);
                if (retorno == null)
                    return BadRequest(new RetornoViewModel { MsgRetorno = "Nenhum registro encontrado", ErrosRetorno = new List<string> { "01" } });
                var usuario = _mapper.Map<Usuarios>(retorno);
                return Ok(retorno);
            }
            catch (Exception e)
            {
                return BadRequest(new RetornoViewModel { MsgRetorno = e.Message.ToString() });
            }

        }

        [HttpPost]
        [AllowAnonymous]
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
        [Authorize]
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
        [Authorize(Roles = "admin")]
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
        [HttpPost("Usuario/Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginViewModel login)
        {
            try
            {
                var retorno = await _service.LogarAsync(login);
                if (retorno == null)
                    return BadRequest(new RetornoViewModel { MsgRetorno = "Nenhum registro encontrado", ErrosRetorno = new List<string> { "01" } });
                var usuario = _mapper.Map<Usuarios>(retorno);
                var token = JwtToken.GerarToken(usuario);
                return Ok(new
                {
                    retorno,
                    token
                });
            }
            catch (Exception e)
            {
                return BadRequest(new RetornoViewModel { MsgRetorno = e.Message.ToString() }); ;
            }

        }

        [HttpPost("Usuario/AlterarSituacao")]
        [Authorize(Roles = "administrador")]
        public async Task<IActionResult> AlterarSituacao([FromBody] SituacaoUsuarioViewModel usuario) {
            
           
            try
            {
                var result = await _service.AvaliarUsuario(usuario);
                return Ok( new RetornoViewModel { MsgRetorno = result.MsgRetorno});
            }
            catch (Exception e)
            {
                return BadRequest( new RetornoViewModel { MsgRetorno = e.Message.ToString()});
            }
        }
    }
}
