using System;
using System.IO;

namespace InjectionHelper
{
  public class InjectorHelper
  {
    public static void LogToFileInCurrentDir(string message)
    {
      File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "injectLogger.txt", Environment.NewLine + message);
    }
  }
}