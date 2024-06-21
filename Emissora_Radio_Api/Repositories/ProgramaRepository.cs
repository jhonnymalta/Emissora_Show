using AutoMapper;
using Emissora_Radio_Api.Data;
using Emissora_Radio_Api.DTOs;
using Emissora_Radio_Api.Interface;
using Emissora_Radio_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Emissora_Radio_Api.Repositories
{
    public class ProgramaRepository : IProgramaRepository
    {
        private AppDbRadioContext _context;
        private IMapper _mapper;

        public ProgramaRepository(AppDbRadioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProgramaDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<ProgramaDTO>>(await _context.Programas.ToListAsync());
        }

        public async Task<ProgramaDTO> GetById(int id)
        {
            return _mapper.Map<ProgramaDTO>( _context.Programas.Where(p => p.Id == id));
        }
        public async Task<ProgramaDTO> Create(ProgramaDTO programa)
        {
            Programa novoPrograma = _mapper.Map<Programa>(programa);
            _context.Programas.AddAsync(novoPrograma);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProgramaDTO>(novoPrograma);
        }

        public async Task<ProgramaDTO> Update(ProgramaDTO programa)
        {
            Programa programaUpdated = _mapper.Map<Programa>(programa);
            _context.Programas.Update(programaUpdated);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProgramaDTO>(programaUpdated);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var programa = await _context.Programas.FirstOrDefaultAsync(p => p.Id == id);
                if (programa == null) return false;
                _context.Programas.Remove(programa);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

      

       
    }
}
