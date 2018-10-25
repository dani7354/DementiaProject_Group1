using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DataAccess;
using WebApplication.DataAccess.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile(env.ContentRootPath + "/config.json")
                .AddJsonFile(env.ContentRootPath + "/config.development.json", true)
                .Build();
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<IdentityDataContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetValue<string>("ConnectionStrings:IdentityDataContext"));
                });
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityDataContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IChatbotAPIService>(x => new QnAMakerAPIService(Options.Create(new QnAAPIServiceOptions()
            {
                Hostname = Configuration.GetValue<string>("ChatbotAPIService:Hostname"),
                KnowledgeBaseId = Configuration.GetValue<string>("ChatbotAPIService:KnowledgeBaseId"),
                EndpointKey = Configuration.GetValue<string>("ChatbotAPIService:EndpointKey")
            })));
            services.AddDbContext<MessageDataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetValue<string>("ConnectionStrings:ChatlogDataContext"));
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute("Default",
                    "{controller=Home}/{action=Index}/{id?}"
                );
            });
            app.UseFileServer();
        }
    }
}
