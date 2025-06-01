using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MvcWebApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var mvcBuilder = services.AddMvc();

            foreach (var dir in Directory.GetDirectories(Path.Combine(AppContext.BaseDirectory, "plugins")))
            {
                var pluginFile = Path.Combine(dir, Path.GetFileName(dir) + ".dll");
                mvcBuilder.AddPluginFromAssemblyFile(pluginFile);
            }
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app
                .UseRouting()
                .UseEndpoints(r =>
                {
                    r.MapDefaultControllerRoute();
                });
        }
    }
}
