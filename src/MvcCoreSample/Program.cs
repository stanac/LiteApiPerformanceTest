using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace MvcCoreSample
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseKestrel()
                .UseUrls("http://localhost:5555")
                .Build();

            host.Run();

            return 0;
        }
    }
}
