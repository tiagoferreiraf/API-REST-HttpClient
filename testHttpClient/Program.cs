using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace testHttpClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient cliente = new HttpClient { BaseAddress = new Uri("http://jsonplaceholder.typicode.com/") };
            var response = await cliente.GetAsync("users");
            var content = await response.Content.ReadAsStringAsync();
           
            var users = JsonConvert.DeserializeObject<Cliente[]>(content);
            
            foreach(var item in users){
                System.Console.WriteLine(item.website);
            }
        }
    }
}
