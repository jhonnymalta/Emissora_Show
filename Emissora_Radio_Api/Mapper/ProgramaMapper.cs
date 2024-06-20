using AutoMapper;
using Emissora_Radio_Api.DTOs;
using Emissora_Radio_Api.Models;

namespace Emissora_Radio_Api.Mapper
{
    public class ProgramaMapper : Profile
    {
        public ProgramaMapper()
        {
            CreateMap<ProgramaDTO,Programa>().ReverseMap();
        }
    }
}
