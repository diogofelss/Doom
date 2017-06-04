using AutoMapper;
using Gaya.Domain.Entities;
using Gaya.Windows.Models;

namespace Gaya.Windows.AutoMapper
{
    public class DomainToModelMappingProfile : Profile
    {
        public DomainToModelMappingProfile()
        {
            CreateMap<UsuarioModel, Usuario>();
            CreateMap<EmpresaModel, Empresa>();
        }
    }
}