using DotNet5.ConsoleApp.HttpClientFeature;
using System;
using System.Threading.Tasks;

namespace DotNet5.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await WeatherRepository.GetWeather();
            Console.WriteLine("Hello World!");
        }
    }
}
