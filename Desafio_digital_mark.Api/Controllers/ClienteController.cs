using Desafio_digital_mark.Application.Interface;
using Desafio_digital_mark.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_digital_mark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAplicacao _clienteAplicacao;

        public ClienteController(IClienteAplicacao clienteAplicacao)
        {
            _clienteAplicacao = clienteAplicacao;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteViewModel>>> SelecionarTodos()
        {
            var clientes = await _clienteAplicacao.SelecionarTodos();
            return Ok(clientes);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClienteViewModel>> SelecionarPorId(int id)
        {
            var cliente = await _clienteAplicacao.SelecionarPorId(id);

            if (cliente is null)
                return NotFound("Cliente não encontrado");

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult> Incluir([FromBody] ClienteViewModel cliente)
        {
            await _clienteAplicacao.Incluir(cliente);
            return Ok("Cliente criado");
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ClienteViewModel>> Atualizar(int id, [FromBody] ClienteViewModel cliente)
        {
            if (cliente.Id != id)
                return BadRequest();

            await _clienteAplicacao.Alterar(cliente);
            return Ok(cliente);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ClienteViewModel>> Excluir(int id)
        {
            await _clienteAplicacao.Excluir(id);
            return Ok("Cliente excluído");
        }

    }
}
