using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.FileProviders;
using System.IO;
/*
using Soukoku.Extensions.FileProviders;
*/

namespace SampleApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            string staticFileDirectory = @"C:/ProgramData/AllGoVision";
            Console.WriteLine(staticFileDirectory);
            /*
                    var zipProvider = new ZipFileProvider(@"C:\ProgramData\AllGoVision");

                    app.UseFileServer(new FileServerOptions()
                    {
                        FileProvider = zipProvider,
                        RequestPath = "/api/test", // optional
                        EnableDirectoryBrowsing = true
                    });

                    .Configure(appbuilder => appbuilder.UseFileServer(true).Build())
         */
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStaticFiles();
            if (Directory.Exists(staticFileDirectory))
            {
                app.UseFileServer(new FileServerOptions
                {
                    FileProvider = new PhysicalFileProvider(
                       staticFileDirectory),
                    RequestPath = "/files",
                    EnableDirectoryBrowsing = true
                });
            }
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
