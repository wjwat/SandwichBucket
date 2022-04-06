using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace SandwichBucket
{
  public class Program
  {
    public static void Main(string[] args)
    {
//       app.UseStaticFiles(new StaticFileOptions
// {
//     ServeUnknownFileTypes = true
// });
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        
        .UseStartup<Startup>()
        
        .Build();

      host.Run();
    }
  }
}
