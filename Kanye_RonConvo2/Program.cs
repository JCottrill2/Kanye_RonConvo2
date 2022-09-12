using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
namespace Kanye_RonConvo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 5; i++)
            {

                var quote = new QuoteGenerator();
                Console.WriteLine($"-----------------");
                Console.WriteLine($"Kanye: '{QuoteGenerator.Kanye()}'");
                Console.WriteLine($"-----------------");
                Console.WriteLine($"Ron: '{QuoteGenerator.RonSwanson()}'");
            }
        }
    }
}