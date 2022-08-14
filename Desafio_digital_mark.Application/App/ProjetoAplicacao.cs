using AutoMapper;
using Desafio_digital_mark.Application.Interface;
using Desafio_digital_mark.Application.ViewModel;
using Desafio_digital_mark.Domain.Modelo;
using Desafio_digital_mark.Domain.Repositorio;

namespace Desafio_digital_mark.Application.App;

public class ProjetoAplicacao : IProjetoAplicacao
{
    private readonly IProjetoRepositorio _projetoRepositorio;
    private readonly IMapper _mapper;

    public ProjetoAplicacao(IProjetoRepositorio projetoRepositorio, IMapper mapper)
    {
        _projetoRepositorio = projetoRepositorio;
        _mapper = mapper;
    }

    public async Task Alterar(ProjetoViewModel projeto)
    {       
        var p = await _projetoRepositorio.Selecionar(p => p.Id == projeto.Id);

        if (p != null)
        {
            p.AlterarTecnologia(projeto.Tecnologia);
            p.AlterarNome(projeto.Nome);
            p.AlterarCliente(projeto.ClienteId);
            await _projetoRepositorio.Alterar(p);
        }                
    }

    public async Task Excluir(int id)
    {
        await _projetoRepositorio.Excluir(p => p.Id == id);
    }

    public async Task Incluir(ProjetoViewModel projeto)
    {
        Projeto p = Projeto.CriarProjeto(projeto.Nome, projeto.Tecnologia, projeto.ClienteId);
        await _projetoRepositorio.Incluir(p);        
    }

    public async Task<ProjetoViewModel> SelecionarPorId(int id)
    {
        var projeto = await _projetoRepositorio.SelecionarProjetoComCliente(p => p.Id == id);
        return _mapper.Map<ProjetoViewModel>(projeto);
    }

    public async Task<IEnumerable<ProjetoViewModel>> SelecionarTodos()
    {
        var projetos = await _projetoRepositorio.SelecionarProjetosComClientesAsync();
        return _mapper.Map<IEnumerable<ProjetoViewModel>>(projetos);
    }
}
