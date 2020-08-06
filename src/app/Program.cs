using System;

namespace Salai.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Salai from {0}!", Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
        }
    }
}
