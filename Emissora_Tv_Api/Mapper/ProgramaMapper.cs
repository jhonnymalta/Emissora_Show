using AutoMapper;
using Emissora_Tv_Api.DTOs;
using Emissora_Tv_Api.Models;

namespace Emissora_Tv_Api.Mapper
{
    public class ProgramaMapper : Profile
    {
        public ProgramaMapper()
        {
            CreateMap<ProgramaDTO, Programa>().ReverseMap();
        }
        
    }
}
