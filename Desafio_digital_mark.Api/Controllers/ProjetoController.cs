using Desafio_digital_mark.Application.Interface;
using Desafio_digital_mark.Application.ViewModel;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_digital_mark.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {

        private readonly IProjetoAplicacao _projetoAplicacao;

        public ProjetoController(IProjetoAplicacao projetoAplicacao)
        {
            _projetoAplicacao = projetoAplicacao;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjetoViewModel>>> SelecionarTodos()
        {
            var projetos = await _projetoAplicacao.SelecionarTodos();
            return Ok(projetos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProjetoViewModel>> SelecionarPorId(int id)
        {
            var projeto = await _projetoAplicacao.SelecionarPorId(id);

            if (projeto is null)
                return NotFound("Projeto não encontrado");

            return Ok(projeto);
        }

        [HttpPost]
        public async Task<ActionResult<ProjetoViewModel>> Incluir([FromBody] ProjetoViewModel projeto)
        {
            await _projetoAplicacao.Incluir(projeto);
            return Ok("Projeto criado");
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProjetoViewModel>> Atualizar(int id, [FromBody] ProjetoViewModel projeto)
        {
            if (projeto.Id != id)
                return NotFound();

            await _projetoAplicacao.Alterar(projeto);
            return Ok(projeto);
        }

        [HttpPatch("{id:int}")]
        public async Task<ActionResult<ProjetoViewModel>> Atualizar(int id, [FromBody] JsonPatchDocument<ProjetoViewModel> projeto)
        {
            var projetoAtualizar = await _projetoAplicacao.SelecionarPorId(id);

            if (projetoAtualizar is null)
                return NotFound();

            projeto.ApplyTo(projetoAtualizar);

            var isValid = TryValidateModel(projetoAtualizar);

            if (!isValid)
                return BadRequest(ModelState);

            await _projetoAplicacao.Alterar(projetoAtualizar);

            return Ok(projetoAtualizar);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ProjetoViewModel>> Excluir(int id)
        {
            await _projetoAplicacao.Excluir(id);
            return Ok("Projeto excluído");
        }

    }
}
