using Emissora_Radio_Api.DTOs;
using Emissora_Radio_Api.Models;

namespace Emissora_Radio_Api.Interface
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
