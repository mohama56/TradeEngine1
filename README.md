# TradeEngine

A scalable trading engine implementation designed to manage and execute trades efficiently. This project demonstrates the use of .NET Core for creating robust, high-performance systems and serves as an educational tool for understanding the core concepts of trading engine development.

## Features

- **Trading Engine**: Manages and processes trades efficiently.
- **Configuration Management**: Uses `appsettings.json` for easy configuration.
- **Dependency Injection**: Leverages modern design patterns for clean and maintainable code.
- **Background Service**: Implements `BackgroundService` to manage trade processing asynchronously.

## Technologies Used

- **Language**: C#
- **Framework**: .NET Core
- **IDE**: JetBrains Rider
- **Dependency Injection**: Microsoft.Extensions.DependencyInjection
- **Configuration Management**: Microsoft.Extensions.Configuration

## Project Structure

```
TradeEngine1/
├── appsettings.json         # Configuration file
├── Program.cs               # Main entry point
├── TradingEngineServer.cs   # Core trading engine implementation
├── TradingEngineHostBuilder.cs # Configures services and builds the host
├── TradingEngineServerConfiguration.cs # Handles configuration settings
├── ITradingEngineServer.cs  # Interface for the trading engine
├── TradingEngineServerServiceProvider.cs # Dependency injection container
```

## Setup and Run Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/TradeEngine1.git
   cd TradeEngine1
   ```

2. Open the project in your preferred IDE (e.g., JetBrains Rider or Visual Studio).

3. Configure the `appsettings.json` file:
   ```json
   {
     "TradingEngineServerConfiguration": {
       "TradingEngineServerSettings": {
         "Port": 12000
       }
     }
   }
   ```

4. Run the application:
   - If using Rider, click the **Run** button.
   - Alternatively, use the command line:
     ```bash
     dotnet run
     ```

## How It Works

The trading engine is built as a background service. It continuously processes trades while logging the activity. Key configuration values, such as the port number, are fetched from `appsettings.json` using the options pattern.

### Example Log Output

```
info: TradingEngineServer[0]
      TradingEngineServer is starting on port: 12000
info: TradingEngineServer[0]
      TradingEngineServer is running.
info: TradingEngineServer[0]
      TradingEngineServer on port 12000 has stopped.
```


## License

This project is open for learning and sharing purposes. Be sure to credit [Coding Jesus](https://www.youtube.com/channel/UCz_V5sxhIkpALcZx4C9ZSdA) for the original tutorial!
