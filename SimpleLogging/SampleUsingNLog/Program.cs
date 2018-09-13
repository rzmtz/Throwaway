using NLog;
using System;

namespace SampleUsingNLog
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Sample log file created. See log files");

      Logger logger = LogManager.GetCurrentClassLogger();

      logger.Debug("This is a debug message");
      logger.Error("This is an error message");

      Console.ReadLine();

    }
  }
}
