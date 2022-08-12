using AutoMapper;
using Desafio_digital_mark.Application.Interface;
using Desafio_digital_mark.Application.ViewModel;
using Desafio_digital_mark.Domain.Modelo;
using Desafio_digital_mark.Domain.Repositorio;

namespace Desafio_digital_mark.Application.App;

public class ClienteAplicacao : IClienteAplicacao
{
    private readonly IClienteRepositorio _clienteRepositorio;
    private readonly IMapper _mapper;

    public ClienteAplicacao(IClienteRepositorio clienteRepositorio, IMapper mapper)
    {
        _clienteRepositorio = clienteRepositorio;
        _mapper = mapper;
    }

    public async Task Alterar(ClienteViewModel cliente)
    {
        await _clienteRepositorio.Alterar(_mapper.Map<Cliente>(cliente));
    }

    public async Task Excluir(int id)
    {
        await _clienteRepositorio.Excluir(c => c.Id == id);
    }

    public async Task Incluir(ClienteViewModel cliente)
    {
        await _clienteRepositorio.Incluir(_mapper.Map<Cliente>(cliente));
    }

    public async Task<ClienteViewModel> SelecionarPorId(int id)
    {
        var cliente = await _clienteRepositorio.Selecionar(c => c.Id == id);
        return _mapper.Map<ClienteViewModel>(cliente);
    }

    public async Task<IEnumerable<ClienteViewModel>> SelecionarTodos()
    {
        var clientes = await _clienteRepositorio.SelecionarTodos();
        return _mapper.Map<IEnumerable<ClienteViewModel>>(clientes);
    }
}
