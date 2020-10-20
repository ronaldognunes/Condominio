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
    public class AvisoController : ControllerBase
    {
        private readonly IAvisoService _avisoService;

        public AvisoController(IAvisoService service)
        {
            _avisoService = service;
        }
        // GET: api/<AvisoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _avisoService.ExibirTodosAviso();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
            
        }

        // GET api/<AvisoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var result = await _avisoService.ConsultarAviso(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }

        }

        // POST api/<AvisoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AvisosViewModel value)
        {
            try
            {
                var result = await _avisoService.IncluirAvisos(value);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
        }

        // PUT api/<AvisoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] AvisosViewModel value)
        {
            try
            {
                var result = await _avisoService.AlterarAviso(value);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
        }

        // DELETE api/<AvisoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var result = await _avisoService.ExcluirAviso(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
        }
    }
}
