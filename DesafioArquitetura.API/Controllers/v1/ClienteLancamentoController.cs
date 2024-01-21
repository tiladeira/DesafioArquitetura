using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using DesafioArquitetura.API.DTO;
using DesafioArquitetura.Domain.Entities;
using DesafioArquitetura.Domain.Interfaces.Services;

namespace DesafioArquitetura.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteLancamentoController : ControllerBase
    {
        private readonly IClienteLancamentoService _ClienteLancamentoService;
        private readonly IMapper _mapper;

        public ClienteLancamentoController(IClienteLancamentoService ClienteLancamentoService, IMapper mapper)
        {
            _ClienteLancamentoService = ClienteLancamentoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            { 
                var result = _mapper.Map<IEnumerable<ClienteLancamentoDto>>(await _ClienteLancamentoService.GetAllAsync());
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
                var result = _mapper.Map<ClienteLancamentoDto>(await _ClienteLancamentoService.GetByIdAsync(id));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ClienteLancamentoDto dto)
        {
            try
            {
                var entity = _mapper.Map<ClienteLancamento>(dto);
                var result = await _ClienteLancamentoService.CreateAsync(entity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] ClienteLancamentoDto dto)
        {
            try
            {
                var entity = _mapper.Map<ClienteLancamento>(dto);
                var result = await _ClienteLancamentoService.UpdateAsync(entity);
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
                var result = await _ClienteLancamentoService.DeleteByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
