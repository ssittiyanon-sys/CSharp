using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace JSONDEMO
{
    internal class Program
    {


        static async Task Main(string[] args)
        {
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";
            HttpClient httpClient = new HttpClient();

            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);

                //Deserialize the json response into aw C# array of type Post
                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                foreach (var post in myPosts)
                {
                    Console.WriteLine($"{post.Id} {post.Title}");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
        }
    }
}
