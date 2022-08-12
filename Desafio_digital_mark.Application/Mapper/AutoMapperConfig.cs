using AutoMapper;
using Desafio_digital_mark.Application.ViewModel;
using Desafio_digital_mark.Domain.Modelo;

namespace Desafio_digital_mark.Application.Mapper;

public class AutoMapperConfig : Profile
{
    public static MapperConfiguration RegisterMappings()
    {
        return new MapperConfiguration(x => x.AllowNullCollections = true);
    }

    public AutoMapperConfig()
    {
        CreateMap<Cliente, ClienteViewModel>().ReverseMap();
        CreateMap<Projeto, ProjetoViewModel>().ReverseMap();
    }

}
