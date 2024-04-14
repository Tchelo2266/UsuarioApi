using AutoMapper;
using UsuarioAPI8.Data.Dto.Usuario;
using UsuarioAPI8.Models;

namespace UsuarioAPI8.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile() 
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
