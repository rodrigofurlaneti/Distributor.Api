using Distributor.Domain.Entities;
using Distributor.Domain.SeedWork;
using Distributor.Infrastructure.Repository.Authorize;

namespace Distributor.Service.Service.Authorize
{
    public class AuthorizeService : BaseService, IAuthorizeService
    {
        #region Property

        public readonly IAuthorizeRepository _authorizeRepository;


        #endregion

        #region Constructor

        public AuthorizeService(ILogger logger, IAuthorizeRepository authorizeRepository) : base(logger)
        {
            _authorizeRepository = authorizeRepository;
        }

        #endregion

        #region Methods

        public void Delete(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_Delete");
                _authorizeRepository.Delete(id);
                this._logger.TraceExit("Service_Authorize_Delete");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método Delete, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_DeleteAsync");
                await _authorizeRepository.DeleteAsync(id);
                this._logger.TraceExit("Service_Authorize_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método DeleteAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<AuthorizeEntity> Get()
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_Get");
                var ret = _authorizeRepository.Get();
                this._logger.TraceExit("Service_Authorize_Get");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_Get");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método Get, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<List<AuthorizeEntity>> GetAsync()
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_GetAsync");
                var ret = await _authorizeRepository.GetAsync();
                this._logger.TraceExit("Service_Authorize_GetAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_GetAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método GetAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public AuthorizeEntity GetById(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_GetById");
                var ret = _authorizeRepository.GetById(id);
                this._logger.TraceExit("Service_Authorize_GetById");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_GetById");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método GetById, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<AuthorizeEntity> GetByIdAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_GetByIdAsync");
                var ret = await _authorizeRepository.GetByIdAsync(id);
                this._logger.TraceExit("Service_Authorize_GetByIdAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método GetByIdAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Post(AuthorizeEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_Post");
                _authorizeRepository.Post(entity);
                this._logger.TraceExit("Service_Authorize_Post");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_Post");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método Post, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(AuthorizeEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_PostAsync");
                await _authorizeRepository.PostAsync(entity);
                this._logger.TraceExit("Service_Authorize_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_PostAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método PostAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(AuthorizeEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_Put");
                _authorizeRepository.Put(entity);
                this._logger.TraceExit("Service_Authorize_Put");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_Put");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método Put, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(AuthorizeEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Authorize_PutAsync");
                await _authorizeRepository.PutAsync(entity);
                this._logger.TraceExit("Service_Authorize_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Authorize_PutAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Authorize, método PutAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #endregion
    }
}
