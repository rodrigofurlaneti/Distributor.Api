using Distributor.Domain.SeedWork;

namespace Distributor.Service.Service
{
    public class BaseService
    {
        #region Properties

        public readonly ILogger _logger;

        #endregion

        #region Constructor

        public BaseService(ILogger logger)
        {
            _logger = logger;
        }

        #endregion
    }
}
