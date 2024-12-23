using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TradingEngineServer.Core
{
    interface ITradingEngineServer
    {
        Task Run(CancellationToken token);
    }
}
