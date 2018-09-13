using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace SampleUsingNLog
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Sample log file created. See log files");

      Logger logger = LogManager.GetCurrentClassLogger();

      logger.Debug("This is a debug message");
      logger.Error("This is an error message");

      Console.ReadLine();

    }
  }
}
