using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RavenDBProjeto.Aplication.DTOS;
using RavenDBProjeto.Aplication.Interfaces;

namespace RavenDBProjeto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAplication  _clienteService;

        public ClienteController(IClienteAplication clienteService)
        {
            _clienteService = clienteService;
        }



        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _clienteService.GetAll();
            return Ok(clientes);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(string id)
        {
            var idr = Uri.UnescapeDataString(id);
            var cliente = _clienteService.GetById(idr);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClienteDTO))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post([FromBody] ClienteDTO cliente)
        {
            _clienteService.Add(cliente);
            return Ok(cliente);
        }


        [HttpPut()/*("{id}")*/]
        public IActionResult Put(string id, [FromBody] ClienteDTO cliente)
        {
            
            _clienteService.Update(cliente);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var idr = Uri.UnescapeDataString(id);
            _clienteService.Delete(idr);
           return Ok();

        }
    }
}
