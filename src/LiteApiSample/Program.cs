using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace LiteApiSample
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseKestrel()
                .UseUrls("http://localhost:5555")
                .Build();

            host.Run();

            return 0;
        }
    }
}
