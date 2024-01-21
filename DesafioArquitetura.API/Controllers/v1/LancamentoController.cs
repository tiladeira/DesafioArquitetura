using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using DesafioArquitetura.API.DTO;
using DesafioArquitetura.Domain.Entities;
using DesafioArquitetura.Domain.Interfaces.Services;

namespace DesafioArquitetura.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentoController : ControllerBase
    {
        private readonly ILancamentoService _LancamentoService;
        private readonly IMapper _mapper;

        public LancamentoController(ILancamentoService LancamentoService, IMapper mapper)
        {
            _LancamentoService = LancamentoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            { 
                var result = _mapper.Map<IEnumerable<LancamentoDto>>(await _LancamentoService.GetAllAsync());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                var result = _mapper.Map<LancamentoDto>(await _LancamentoService.GetByIdAsync(id));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] LancamentoDto dto)
        {
            try
            {
                var entity = _mapper.Map<Lancamento>(dto);
                var result = await _LancamentoService.CreateAsync(entity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] LancamentoDto dto)
        {
            try
            {
                var entity = _mapper.Map<Lancamento>(dto);
                var result = await _LancamentoService.UpdateAsync(entity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            try
            {
                var result = await _LancamentoService.DeleteByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
