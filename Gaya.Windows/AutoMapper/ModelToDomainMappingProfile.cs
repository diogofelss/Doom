using AutoMapper;
using Gaya.Domain.Entities;
using Gaya.Windows.Models;

namespace Gaya.Windows.AutoMapper
{
    public class ModelToDomainMappingProfile : Profile
    {
        public ModelToDomainMappingProfile()
        {
            CreateMap<Usuario, UsuarioModel>();
            CreateMap<Empresa, EmpresaModel>();
        }
    }
}