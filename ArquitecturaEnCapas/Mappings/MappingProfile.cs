using ArquitecturaEnCapas.Dtos;
using ArquitecturaEnCapas.Models;
using AutoMapper;

namespace ArquitecturaEnCapas.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<APP_BITACORA_USER, BitacoraUserDto>().ReverseMap();
        }
    }
}
