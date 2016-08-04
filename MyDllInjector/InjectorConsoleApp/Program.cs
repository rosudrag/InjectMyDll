using System;
using DllToInject;
using InjectionHelper;

namespace InjectorConsoleApp
{
  public static class Program
  {
    static void Main()
    {
      var shouter = new HelloWorldShouter();

      InjectorHelper.LogToFileInCurrentDir("nothing");
      Console.WriteLine(shouter.SayHelloWorld());

      Console.ReadLine();
    }
  }
}