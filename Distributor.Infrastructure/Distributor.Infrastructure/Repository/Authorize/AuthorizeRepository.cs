using Distributor.Domain.Entities;
using Distributor.Domain.SeedWork;
using System.Data;
using System.Data.SqlClient;

namespace Distributor.Infrastructure.Repository.Authorize
{
    public class AuthorizeRepository : BaseRepository, IAuthorizeRepository
    {
        public AuthorizeRepository(ILogger logger) : base(logger) { }

        public void Delete(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_Delete");
                _commandText = "USP_Distributor_Authorize_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetAuthorizeDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Authorize_Delete");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_Delete");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método DeleteAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_DeleteAsync");
                _commandText = "USP_Distributor_Authorize_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetAuthorizeDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Authorize_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_DeleteAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método DeleteAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<AuthorizeEntity> Get()
        {
            List<AuthorizeEntity> list = new List<AuthorizeEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_Get");
                _commandText = "USP_Distributor_Authorize_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetListAuthorize(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Authorize_Get");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_Get");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método Get, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public async Task<List<AuthorizeEntity>> GetAsync()
        {
            List<AuthorizeEntity> list = new List<AuthorizeEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_GetAsync");
                _commandText = "USP_Distributor_Authorize_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetListAuthorize(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Authorize_GetAsync");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_GetAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método Get, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public AuthorizeEntity GetById(int id)
        {
            AuthorizeEntity entity = new AuthorizeEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_GetById");
                _commandText = "USP_Distributor_Authorize_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetAuthorize(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Authorize_GetById");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_GetById");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método GetById, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public async Task<AuthorizeEntity> GetByIdAsync(int id)
        {
            AuthorizeEntity entity = new AuthorizeEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_GetByIdAsync");
                _commandText = "USP_Distributor_Authorize_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetAuthorize(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Authorize_GetByIdAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método GetByIdAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public void Post(AuthorizeEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_Post");
                _commandText = "USP_Distributor_Authorize_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetAuthorizeInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Authorize_Post");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_Post");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método Post, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(AuthorizeEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_PostAsync");
                _commandText = "USP_Distributor_Authorize_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetAuthorizeInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Authorize_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_PostAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método PostAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(AuthorizeEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_Put");
                _commandText = "USP_Distributor_Authorize_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetAuthorizeUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Authorize_Put");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_Put");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método Put, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(AuthorizeEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Authorize_PutAsync");
                _commandText = "USP_Distributor_Authorize_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetAuthorizeUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Authorize_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Authorize_PutAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Authorize, método PutAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #region Helpers

        private static void GetListAuthorize(SqlDataReader sqlDataReader, List<AuthorizeEntity> listVehicleAuthorizeModel)
        {
            AuthorizeEntity authorizeModel = new AuthorizeEntity();
            GetAuthorize(sqlDataReader, authorizeModel);
            listVehicleAuthorizeModel.Add(authorizeModel);
        }

        private static void GetAuthorize(SqlDataReader sqlDataReader, AuthorizeEntity authorizeModel)
        {
            authorizeModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
            authorizeModel.Ip = Convert.ToString(sqlDataReader["Ip"]);
            authorizeModel.Key = Convert.ToString(sqlDataReader["Key"]);
        }

        private static void GetAuthorizeInsert(SqlCommand sqlCommand, AuthorizeEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@Ip", entity.Ip);
            sqlCommand.Parameters.AddWithValue("@Key", entity.Key);
        }

        private static void GetAuthorizeUpdate(SqlCommand sqlCommand, AuthorizeEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@Id", entity.Id);
            sqlCommand.Parameters.AddWithValue("@Ip", entity.Ip);
            sqlCommand.Parameters.AddWithValue("@Key", entity.Key);
        }

        private static void GetAuthorizeDelete(SqlCommand sqlCommand, int id)
        {
            sqlCommand.Parameters.AddWithValue("@Id", id);
        }

        #endregion

    }
}
