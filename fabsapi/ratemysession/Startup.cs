using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ratemysession
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
            /*
            //this section is used to get the token from the Configure Below AAD B2C CAll
            services.AddAuthentication(options => 
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options => {
                options.RequireHttpsMetadata = false;
                options.Audience = Configuration["Authentication:AzureAd:ClientId"];
                options.Events = new JwtBearerEvents 
                {
                    OnAuthenticationFailed = AuthenticationFailed
                };
                var authorityBase = string.Format("https://login.microsoftonline.com/tfp/{0}/",Configuration["Authentication:AzureAd:Tenant"]);
            
                options.Authority = string.Format("{0}{1}/v2.0/",authorityBase,Configuration["Authentication:AzureAd:Policy"]);

            });
            //end section
            */
            services.AddMvc();
        }

        Task AuthenticationFailed(AuthenticationFailedContext arg)
        {
            Console.WriteLine(arg.Exception.Message);
            return Task.FromResult(0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //now we configure the app to use Authentication via my Azure AD B2C
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
