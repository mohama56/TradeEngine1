using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using TradingEngineServer.Core.Configuration;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineHostBuilder
    {
        public static IHost BuildTradingEngineServer() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.Configure<TradingEngineServerConfiguration>(context.Configuration.GetSection("TradingEngineServerConfiguration"));
                    services.AddSingleton<TradingEngineServerConfiguration>();
                    services.AddHostedService<TradingEngineServer>();
                })
                .Build();
    }
}

