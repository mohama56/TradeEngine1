using System.Threading.Tasks;
using TradingEngineServer.Core;
using Microsoft.Extensions.Hosting;


namespace TradingEngineServer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var engineHost = TradingEngineHostBuilder.BuildTradingEngineServer();
            await engineHost.RunAsync();
        }
    }
}