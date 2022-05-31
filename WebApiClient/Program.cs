using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApiClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("press any key cont...");
            Console.ReadLine();

            using (System.Net.Http.HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:34063/values");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string messagee = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(messagee);
                }
                else
                {
                    Console.WriteLine($"response error code: {response.StatusCode}");
                }    
            }
        }
    }
}
