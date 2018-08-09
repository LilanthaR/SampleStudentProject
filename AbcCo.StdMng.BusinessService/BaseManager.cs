using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcCo.StdMng.BusinessService
{
    public abstract class BaseManager
    {
        protected ILogger _logger;
        protected IAppSettings _appSettings;


        public BaseManager(IAppSettings appSettings, ILogger logger)
        {
            this._logger = logger;
            this._appSettings = appSettings;
        }

    }
}
