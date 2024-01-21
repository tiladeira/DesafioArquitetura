string pastaBaseGerador = "C:\\Gerador\\";
string pastaBaseProjeto = "C:\\Projetos\\DesafioArquitetura\\";


Console.WriteLine("Iniciando a geração da estrutura ...");
Console.WriteLine("Digite o nome do objeto a ser criado");
string nomeObj = Console.ReadLine();

Console.WriteLine("Criando API ....");
string conteudoController = "using AutoMapper;\r\n\r\nusing Microsoft.AspNetCore.Mvc;\r\n\r\nusing DesafioArquitetura.API.DTO;\r\nusing DesafioArquitetura.Domain.Entities;\r\nusing DesafioArquitetura.Domain.Interfaces.Services;\r\n\r\nnamespace DesafioArquitetura.API.Controllers.v1\r\n{\r\n    [Route(\"api/[controller]\")]\r\n    [ApiController]\r\n    public class nomeObjController : ControllerBase\r\n    {\r\n        private readonly InomeObjService _nomeObjService;\r\n        private readonly IMapper _mapper;\r\n\r\n        public nomeObjController(InomeObjService nomeObjService, IMapper mapper)\r\n        {\r\n            _nomeObjService = nomeObjService;\r\n            _mapper = mapper;\r\n        }\r\n\r\n        [HttpGet]\r\n        public async Task<IActionResult> GetAllAsync()\r\n        {\r\n            try\r\n            { \r\n                var result = _mapper.Map<IEnumerable<nomeObjDto>>(await _nomeObjService.GetAllAsync());\r\n                return Ok(result);\r\n            }\r\n            catch (Exception ex)\r\n            {\r\n                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);\r\n            }\r\n        }\r\n\r\n        [HttpGet(\"{id:int}\")]\r\n        public async Task<IActionResult> GetByIdAsync(int id)\r\n        {\r\n            try\r\n            {\r\n                var result = _mapper.Map<nomeObjDto>(await _nomeObjService.GetByIdAsync(id));\r\n                return Ok(result);\r\n            }\r\n            catch (Exception ex)\r\n            {\r\n                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);\r\n            }\r\n        }\r\n\r\n        [HttpPost]\r\n        public async Task<IActionResult> CreateAsync([FromBody] nomeObjDto dto)\r\n        {\r\n            try\r\n            {\r\n                var entity = _mapper.Map<nomeObj>(dto);\r\n                var result = await _nomeObjService.CreateAsync(entity);\r\n                return Ok(result);\r\n            }\r\n            catch (Exception ex)\r\n            {\r\n                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);\r\n            }\r\n        }\r\n\r\n        [HttpPut]\r\n        public async Task<IActionResult> UpdateAsync([FromBody] nomeObjDto dto)\r\n        {\r\n            try\r\n            {\r\n                var entity = _mapper.Map<nomeObj>(dto);\r\n                var result = await _nomeObjService.UpdateAsync(entity);\r\n                return Ok(result);\r\n            }\r\n            catch (Exception ex)\r\n            {\r\n                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);\r\n            }\r\n        }\r\n\r\n        [HttpDelete(\"{id:int}\")]\r\n        public async Task<IActionResult> DeleteByIdAsync(int id)\r\n        {\r\n            try\r\n            {\r\n                var result = await _nomeObjService.DeleteByIdAsync(id);\r\n                return Ok(result);\r\n            }\r\n            catch (Exception ex)\r\n            {\r\n                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);\r\n            }\r\n        }\r\n    }\r\n}\r\n";
string nomeArquivoController = nomeObj + "Controller.cs";
string caminhoCompletoController = Path.Combine(pastaBaseProjeto + "DesafioArquitetura.API\\Controllers\\v1\\", nomeArquivoController);

if (!Directory.Exists(pastaBaseGerador))
    Directory.CreateDirectory(pastaBaseGerador);

conteudoController = conteudoController.Replace("nomeObj", nomeObj);
File.WriteAllText(caminhoCompletoController, conteudoController);
Console.WriteLine($"Arquivo gerado com sucesso em: {caminhoCompletoController}");
Console.WriteLine("Criação da API Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Configurando AutoMapper ....");
string caminhoArquivoMapper = pastaBaseProjeto + "DesafioArquitetura.API\\AutoMapper\\MapperProfile.cs";
string conteudo = File.ReadAllText(caminhoArquivoMapper);
string textoProcurado = "//NovoItem//";
string novoTexto = "CreateMap<" + nomeObj + ", " + nomeObj + "Dto>().ReverseMap();\n //NovoItem//";
string novoConteudo = conteudo.Replace(textoProcurado, novoTexto);
File.WriteAllText(caminhoArquivoMapper, novoConteudo);
Console.WriteLine($"Texto modificado com sucesso no arquivo: {caminhoArquivoMapper}");
Console.WriteLine("Configuração do AutoMapper Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Criando DTO ....");
string conteudoDTO = "using System.ComponentModel.DataAnnotations;\r\n\r\nnamespace DesafioArquitetura.API.DTO\r\n{\r\n    public class nomeDtoDto \r\n    {\r\n        public int Id { get; set; }\r\n\r\n        [Required(ErrorMessage = \"O campo {0} é obrigatório.\")]\r\n        public string Descricao { get; set; }\r\n    }\r\n}\r\n";
string nomeArquivoDTO = nomeObj + "Dto.cs";
string caminhoCompletoDTO = Path.Combine(pastaBaseProjeto + "DesafioArquitetura.API\\DTO\\", nomeArquivoDTO);

if (!Directory.Exists(pastaBaseGerador))
    Directory.CreateDirectory(pastaBaseGerador);

conteudoDTO = conteudoDTO.Replace("nomeDto", nomeObj);
File.WriteAllText(caminhoCompletoDTO, conteudoDTO);
Console.WriteLine($"Arquivo gerado com sucesso em: {caminhoCompletoDTO}");
Console.WriteLine("Criação do DTO Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Criando Entidade ....");
string conteudoEntities = "using DesafioArquitetura.Domain.Entities.Base;\r\n\r\nnamespace DesafioArquitetura.Domain.Entities\r\n{\r\n    public class nomeEntities : BaseEntity\r\n    {\r\n    }\r\n}";
string nomeArquivoEntities = nomeObj + ".cs";
string caminhoCompletoEntities = Path.Combine(pastaBaseProjeto + "DesafioArquitetura.Domain\\Entities\\", nomeArquivoEntities);

if (!Directory.Exists(pastaBaseGerador))
    Directory.CreateDirectory(pastaBaseGerador);

conteudoEntities = conteudoEntities.Replace("nomeEntities", nomeObj);
File.WriteAllText(caminhoCompletoEntities, conteudoEntities);
Console.WriteLine($"Arquivo gerado com sucesso em: {caminhoCompletoEntities}");
Console.WriteLine("Criação da Entidade Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Criando Interface Repositorio ....");
string conteudoInterfaceRepositorio = "using DesafioArquitetura.Domain.Entities;\r\nusing DesafioArquitetura.Domain.Interfaces.Base;\r\n\r\nnamespace DesafioArquitetura.Domain.Interfaces.Repositories\r\n{\r\n    public interface InomeInterfaceRepositorioRepository : IRepositoryBase<nomeInterfaceRepositorio>\r\n    {\r\n    }\r\n}";
string nomeArquivoInterfaceRepositorio = "I" + nomeObj + "Repository.cs";
string caminhoCompletoInterfaceRepositorio = Path.Combine(pastaBaseProjeto + "DesafioArquitetura.Domain\\Interfaces\\Repositories\\", nomeArquivoInterfaceRepositorio);

if (!Directory.Exists(pastaBaseGerador))
    Directory.CreateDirectory(pastaBaseGerador);

conteudoInterfaceRepositorio = conteudoInterfaceRepositorio.Replace("nomeInterfaceRepositorio", nomeObj);
File.WriteAllText(caminhoCompletoInterfaceRepositorio, conteudoInterfaceRepositorio);
Console.WriteLine($"Arquivo gerado com sucesso em: {caminhoCompletoInterfaceRepositorio}");
Console.WriteLine("Criação da Interface Repositorio Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Criando Interface Servico ....");
string conteudoInterfaceServico = "using DesafioArquitetura.Domain.Entities;\r\nusing DesafioArquitetura.Domain.Interfaces.Base;\r\n\r\nnamespace DesafioArquitetura.Domain.Interfaces.Services\r\n{\r\n    public interface InomeInterfaceServiceService : IServiceBase<nomeInterfaceService>\r\n    {\r\n    }\r\n}";
string nomeArquivoInterfaceServico = "I" + nomeObj + "Service.cs";
string caminhoCompletoInterfaceServico = Path.Combine(pastaBaseProjeto + "DesafioArquitetura.Domain\\Interfaces\\Services\\", nomeArquivoInterfaceServico);

if (!Directory.Exists(pastaBaseGerador))
    Directory.CreateDirectory(pastaBaseGerador);

conteudoInterfaceServico = conteudoInterfaceServico.Replace("nomeInterfaceService", nomeObj);
File.WriteAllText(caminhoCompletoInterfaceServico, conteudoInterfaceServico);
Console.WriteLine($"Arquivo gerado com sucesso em: {caminhoCompletoInterfaceServico}");
Console.WriteLine("Criação da Interface Servico Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Criando Servico ....");
string conteudoServico = "using DesafioArquitetura.Domain.Entities;\r\nusing DesafioArquitetura.Domain.Interfaces.Repositories;\r\nusing DesafioArquitetura.Domain.Interfaces.Services;\r\n\r\nnamespace DesafioArquitetura.Domain.Services\r\n{\r\n    public class nomeServiceService : InomeServiceService\r\n    {\r\n        private readonly IUnitOfWorkRepository _unitOfWork;\r\n\r\n        public nomeServiceService(IUnitOfWorkRepository unitOfWork)\r\n        {\r\n            _unitOfWork = unitOfWork;\r\n        }\r\n\r\n        public async Task<bool> CreateAsync(nomeService entity)\r\n        {\r\n            if (entity != null)\r\n            {\r\n                await _unitOfWork.nomeService.CreateAsync(entity);\r\n                var result = _unitOfWork.Save();\r\n\r\n                if (result > 0)\r\n                    return true;\r\n                else\r\n                    return false;\r\n            }\r\n\r\n            return false;\r\n        }\r\n\r\n        public async Task<bool> DeleteByIdAsync(int id)\r\n        {\r\n            if (id > 0)\r\n            {\r\n                var entity = await _unitOfWork.nomeService.GetByIdAsync(id);\r\n\r\n                if (entity != null)\r\n                {\r\n                    await _unitOfWork.nomeService.DeleteByAsync(entity).ConfigureAwait(false);\r\n                    var result = _unitOfWork.Save();\r\n\r\n                    if (result > 0)\r\n                        return true;\r\n                    else\r\n                        return false;\r\n                }\r\n            }\r\n\r\n            return false;\r\n        }\r\n\r\n        public async Task<IEnumerable<nomeService>> GetAllAsync()\r\n        {\r\n            return await _unitOfWork.nomeService.GetAllAsync();\r\n        }\r\n\r\n        public async Task<nomeService> GetByIdAsync(int id)\r\n        {\r\n            if (id > 0)\r\n            {\r\n                var entity = await _unitOfWork.nomeService.GetByIdAsync(id);\r\n\r\n                if (entity != null)\r\n                    return entity;\r\n            }\r\n\r\n            return null;\r\n        }\r\n\r\n        public async Task<bool> UpdateAsync(nomeService entity)\r\n        {\r\n            if (entity != null)\r\n            {\r\n                await _unitOfWork.nomeService.UpdateAsync(entity);\r\n                var result = _unitOfWork.Save();\r\n\r\n                if (result > 0)\r\n                    return true;\r\n                else\r\n                    return false;\r\n            }\r\n\r\n            return false;\r\n        }\r\n    }\r\n}";
string nomeArquivoServico = nomeObj + "Service.cs";
string caminhoCompletoServico = Path.Combine(pastaBaseProjeto + "DesafioArquitetura.Domain\\Services\\", nomeArquivoServico);

if (!Directory.Exists(pastaBaseGerador))
    Directory.CreateDirectory(pastaBaseGerador);

conteudoServico = conteudoServico.Replace("nomeService", nomeObj);
File.WriteAllText(caminhoCompletoServico, conteudoServico);
Console.WriteLine($"Arquivo gerado com sucesso em: {caminhoCompletoServico}");
Console.WriteLine("Criação Servico Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Criando Repositorio ....");
string conteudoRepositorio = "using DesafioArquitetura.Domain.Entities;\r\nusing DesafioArquitetura.Domain.Interfaces.Repositories;\r\nusing DesafioArquitetura.Infra.Data.Context;\r\n\r\nusing DesafioArquitetura.Infra.Data.Repository.Base;\r\n\r\nnamespace DesafioArquitetura.Infra.Data.Repository\r\n{\r\n    public class nomeRepositoryRepository : RepositoryBase<nomeRepository>, InomeRepositoryRepository\r\n    {\r\n        public nomeRepositoryRepository(AppDbContext appContext) : base(appContext)\r\n        {\r\n\r\n        }\r\n    }\r\n}";
string nomeArquivoRepositorio = nomeObj + "Repository.cs";
string caminhoCompletoRepositorio = Path.Combine(pastaBaseProjeto + "DesafioArquitetura.Infra.Data\\Repository\\", nomeArquivoRepositorio);

if (!Directory.Exists(pastaBaseGerador))
    Directory.CreateDirectory(pastaBaseGerador);

conteudoRepositorio = conteudoRepositorio.Replace("nomeRepository", nomeObj);
File.WriteAllText(caminhoCompletoRepositorio, conteudoRepositorio);
Console.WriteLine($"Arquivo gerado com sucesso em: {caminhoCompletoRepositorio}");
Console.WriteLine("Criação Repositorio Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Configurando Context ....");
string caminhoArquivoContext = pastaBaseProjeto + "DesafioArquitetura.Infra.Data\\Context\\AppDbContext.cs";
string conteudoContext = File.ReadAllText(caminhoArquivoContext);
string textoProcuradoContext = "//ConfigDbSet//";
string novoTextoContext = "public DbSet<//ConfigDbSet//>? //ConfigDbSet//s { get; set; }";
string novoConteudoContext = conteudoContext.Replace(textoProcuradoContext, novoTextoContext);
File.WriteAllText(caminhoArquivoContext, novoConteudoContext);
Console.WriteLine($"Texto modificado com sucesso no arquivo: {caminhoArquivoContext}");
Console.WriteLine("Configuração do Context Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////



//Console.WriteLine("Configurando UnitOfWork ....");
//string caminhoArquivoUnitOfWork = pastaBaseProjeto + "DesafioArquitetura.Infra.Data\\Repository\\UnitOfWorkRepository.cs";
//string conteudoUnitOfWork = File.ReadAllText(caminhoArquivoUnitOfWork);

//string textoProcuradoUnitOfWork = "//ConfigUnitOfWorkRepository//";
//string novoTextoUnitOfWork = "";
//string novoConteudoUnitOfWork = conteudoContext.Replace(textoProcuradoUnitOfWork, novoTextoUnitOfWork);

//File.WriteAllText(caminhoArquivoUnitOfWork, novoConteudoUnitOfWork);
//Console.WriteLine($"Texto modificado com sucesso no arquivo: {caminhoArquivoUnitOfWork}");
//Console.WriteLine("Configuração do UnitOfWork Finalizada");
/////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Configurando Ioc ....");
//string caminhoArquivoContext = pastaBaseProjeto + "DesafioArquitetura.Infra.Data\\Context\\AppDbContext.cs";
//string conteudoContext = File.ReadAllText(caminhoArquivoContext);
//string textoProcuradoContext = "//ConfigDbSet//";
//string novoTextoContext = "public DbSet<//ConfigDbSet//>? //ConfigDbSet//s { get; set; }";
//string novoConteudoContext = conteudoContext.Replace(textoProcuradoContext, novoTextoContext);

//File.WriteAllText(caminhoArquivoContext, novoConteudoContext);
//Console.WriteLine($"Texto modificado com sucesso no arquivo: {caminhoArquivoContext}");
//Console.WriteLine("Configuração do Ioc Finalizada");
///////////////////////////////////////////////////////////////////////////////////////////
