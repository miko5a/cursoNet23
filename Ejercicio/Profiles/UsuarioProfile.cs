using AutoMapper;
using Entidades;

namespace ConversoApi.Profiles;
public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<Consulta, UsuarioVerDto>();
        CreateMap<UsuarioVerDto, Consulta>();
    }
}
