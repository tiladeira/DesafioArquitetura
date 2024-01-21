using DesafioArquitetura.API.DTO;
using DesafioArquitetura.Domain.Entities;

namespace DesafioArquitetura.API.AutoMapper
{
    public class MapperProfile : global::AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateMap<Lancamento, LancamentoDto>().ReverseMap();
            CreateMap<Lancamento, LancamentoDto>().ReverseMap();
            CreateMap<ClienteLancamento, ClienteLancamentoDto>().ReverseMap();
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            //NovoItem//
        }
    }
}
