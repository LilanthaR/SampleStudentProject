using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcCo.StdMng.Common.Confugurations
{
    public interface IAppSettings
    {
         string DbConnectionName { get;  }
        int SessionTimeOut { get; }

    }
}
