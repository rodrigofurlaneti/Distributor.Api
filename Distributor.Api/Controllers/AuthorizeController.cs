using Distributor.Domain.Entities;
using Distributor.Service.Service.Authorize;
using Microsoft.AspNetCore.Mvc;

namespace Distributor.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorizeController : ControllerBase, IController<AuthorizeEntity>
    {
        private readonly ILogger<AuthorizeController> _logger;
        private readonly IAuthorizeService _authorizeService;

        public AuthorizeController(ILogger<AuthorizeController> logger, IAuthorizeService authorizeService)
        {
            this._logger = logger;
            this._authorizeService = authorizeService;
        }

        [HttpGet(Name = "GetAuthorize")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AuthorizeEntity>))]
        public async Task<IActionResult> Get()
        {
            try
            {
                this._logger.LogInformation("WebApi_Authorize_GetAsync_Entry");
                var ret = await _authorizeService.GetAsync();
                this._logger.LogInformation("WebApi_Authorize_GetAsync_Exit");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Authorize_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Authorize, rota Get " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AuthorizeEntity>))]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Authorize_GetByIdAsync_Entry");
                var ret = await _authorizeService.GetByIdAsync(id);
                this._logger.LogInformation("WebApi_Authorize_GetByIdAsync_Entry");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Authorize_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Authorize, rota GetByIdAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpPost(Name = "InsertAuthorize")]
        public async Task Post(AuthorizeEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Authorize_PostAsync_Entry");
                await _authorizeService.PostAsync(entity);
                this._logger.LogInformation("WebApi_Authorize_PostAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Authorize_PostAsync_Exception");
                string mensagem = "Erro ao consumir a controler Authorize, rota PostAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpPut(Name = "UpdateAuthorize")]
        public async Task Put(AuthorizeEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Authorize_PutAsync_Entry");
                await _authorizeService.PutAsync(entity);
                this._logger.LogInformation("WebApi_Authorize_PutAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Authorize_PutAsync_Exception");
                string mensagem = "Erro ao consumir a controler Authorize, rota Put " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Authorize_DeleteAsync_Entry");
                await _authorizeService.DeleteAsync(id);
                this._logger.LogInformation("WebApi_Authorize_DeleteAsync_Exit");
            }
            catch (Exception ex)
            {
                _logger.LogInformation("WebApi_Authorize_DeleteAsync_Exception");
                string mensagem = "Erro ao consumir a controler Authorize, rota DeleteAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }
    }
}