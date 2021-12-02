using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateway
{
    public class Startup
    {
        private IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot(_configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // � importante que esta sempre seja a �ltima linha do m�todo Configure.
            // Pois o middleware do Ocelot � terminal. Ou seja, ele n�o invoca nenhum outro middleware do pipeline.
            // Caso a solicita��o realizada n�o seja encontrada nas configura��es do Ocelot, ele gera um erro 404.
            app.UseOcelot().Wait();
        }
    }
}
