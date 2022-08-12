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
        await _projetoRepositorio.Alterar(_mapper.Map<Projeto>(projeto));
    }

    public async Task Excluir(int id)
    {
        await _projetoRepositorio.Excluir(p => p.Id == id);
    }

    public async Task Incluir(ProjetoViewModel projeto)
    {
        await _projetoRepositorio.Incluir(_mapper.Map<Projeto>(projeto));
    }

    public async Task<ProjetoViewModel> SelecionarPorId(int id)
    {
        var projeto = await _projetoRepositorio.Selecionar(p => p.Id == id);
        return _mapper.Map<ProjetoViewModel>(projeto);
    }

    public async Task<IEnumerable<ProjetoViewModel>> SelecionarTodos()
    {
        var projetos = await _projetoRepositorio.SelecionarProjetosComClientesAsync();
        return _mapper.Map<IEnumerable<ProjetoViewModel>>(projetos);
    }
}
