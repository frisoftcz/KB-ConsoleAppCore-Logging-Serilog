using System;
using Serilog;

namespace KB_ConsoleAppCore_Logging_Serilog
{
  class Program
  {
    static void Main(string[] args)
    {
      ILogger log = new LoggerConfiguration().WriteTo.File("log.txt").CreateLogger();
      log.Information("Hello from Serilog.");
      log.Warning("Warning from Serilog.");
      log.Error("Error from Serilog.");

      Console.WriteLine("Hello World!");
    }
  }
}
