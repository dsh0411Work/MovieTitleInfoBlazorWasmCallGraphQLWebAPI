using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TitleInfoClient.DataServices;

namespace TitleInfoClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //TODO:  Delete this before release
            Console.WriteLine("TitleInfoClient has started");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["api_base_url"]) });//builder.HostEnvironment.BaseAddress) });

            builder.Services.AddHttpClient<ITitlesDataService, TitleInfoDataServiceGraphQL>
            (titleDS => titleDS.BaseAddress = new Uri(builder.Configuration["api_base_url"]));

            await builder.Build().RunAsync();
        }
    }
}
