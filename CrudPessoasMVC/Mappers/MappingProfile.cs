using AutoMapper;
using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Enums;
using CrudPessoasDDD.MVC.Models;

namespace CrudPessoasDDD.MVC.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Endereco, EnderecoGridModel>()
                .ForMember(dest => dest.EnderecoCompleto, map => map.MapFrom(src => $"{src.Cidade} {src.Estado}"));

            CreateMap<Pessoa, PessoaGridModel>()
                .ForMember(dest => dest.Sexo, map => map.MapFrom(src => src.Sexo == Sexo.Masculino ? "M" : "F"))
                .ForMember(dest => dest.NomeCompleto, map => map.MapFrom(src => $"{src.Nome} {src.Sobrenome}"));

            CreateMap<Pessoa, PessoaModel>();

        }
    }
}
