using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using DesafioArquitetura.API.DTO;
using DesafioArquitetura.Domain.Entities;
using DesafioArquitetura.Domain.Interfaces.Services;

namespace DesafioArquitetura.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _ClienteService;
        private readonly IMapper _mapper;

        public ClienteController(IClienteService ClienteService, IMapper mapper)
        {
            _ClienteService = ClienteService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            { 
                var result = _mapper.Map<IEnumerable<ClienteDto>>(await _ClienteService.GetAllAsync());
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
                var result = _mapper.Map<ClienteDto>(await _ClienteService.GetByIdAsync(id));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ClienteDto dto)
        {
            try
            {
                var entity = _mapper.Map<Cliente>(dto);
                var result = await _ClienteService.CreateAsync(entity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] ClienteDto dto)
        {
            try
            {
                var entity = _mapper.Map<Cliente>(dto);
                var result = await _ClienteService.UpdateAsync(entity);
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
                var result = await _ClienteService.DeleteByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
