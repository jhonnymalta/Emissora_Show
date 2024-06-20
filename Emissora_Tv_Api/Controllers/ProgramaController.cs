using Emissora_Tv_Api.DTOs;
using Emissora_Tv_Api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emissora_Tv_Api.Controllers
{
    [ApiController]    
    [Route("api/v1/programa")]
    public class ProgramaController : ControllerBase
    {
        private readonly IProgramaRepository _programaRepository;

        public ProgramaController(IProgramaRepository programaRepository)
        {
            _programaRepository = programaRepository;
        }
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ProgramaDTO>>> BuscarTodos()
        {
            var listaDeProgramas = await _programaRepository.GetAll();
            if (listaDeProgramas == null) return NotFound();
            return Ok(listaDeProgramas);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<ProgramaDTO>>> BuscarPorId([FromRoute] int id)
        {
            var programa = await _programaRepository.GetById(id);
            if (programa == null) return NotFound();
            return Ok(programa);
        }



        [HttpPost("novo-programa")]
        public async Task<ActionResult<ProgramaDTO>> Adicionar(ProgramaDTO programa)
        {
            var result = await _programaRepository.Create(programa);
            if (result == null) return BadRequest();
            return Ok(programa);
        }

        [HttpPut()]
        public async Task<ActionResult<ProgramaDTO>> Atualizar(ProgramaDTO programa)
        {
            var result = await _programaRepository.Update(programa);
            if (result == null) return BadRequest();
            return Ok(programa);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ProgramaDTO>> Remove(int id)
        {
            var result = await _programaRepository.Delete(id);
            if(!result) return BadRequest();
            return Ok(result);
        }
    }
}
