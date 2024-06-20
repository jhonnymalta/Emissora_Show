using Emissora_Tv_Api.DTOs;
using Emissora_Tv_Api.Models;

namespace Emissora_Tv_Api.Interfaces
{
    public interface IProgramaRepository
    {
        Task<IEnumerable<ProgramaDTO>> GetAll();
        Task<ProgramaDTO> GetById(int id);
        Task<ProgramaDTO> Create(ProgramaDTO programa);
        Task<ProgramaDTO> Update(ProgramaDTO programa);
        Task<bool> Delete(int id);
    }
}
