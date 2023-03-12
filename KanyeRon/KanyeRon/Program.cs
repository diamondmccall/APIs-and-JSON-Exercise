using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace KanyeRon
{
     class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new Quote(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {quote.Kanye()}");

                Console.WriteLine("------------------------");
                Console.WriteLine($"Ron: {quote.Ron()}");

            }
        }
    }
}