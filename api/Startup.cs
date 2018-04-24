using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Microsoft.EntityFrameworkCore;
using SysDente.Entities;
using SysDente.Contexts;
using SysDente.Repositories;

using SysDente.Services;
using SysDente.Services.Impl;

namespace api
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
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServer")));

            services.AddMvc();
            services.AddScoped<IAgendaRepository, AgendaRepository>();
            services.AddScoped<IConvenioRepository, ConvenioRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IHistoricoPacienteRepository, HistoricoPacienteRepository>();
            services.AddScoped<IPacienteConvenioRepository, PacienteConvenioRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IDentistaRepository, DentistaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IExameRepository, ExameRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IPacienteRepository, PacienteRepository>();

            services.AddScoped<IAgendaService, AgendaService>();
            services.AddScoped<IConvenioService, ConvenioService>();
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IEstadoService, EstadoService>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IHistoricoPacienteService, HistoricoPacienteService>();
            services.AddScoped<IPacienteConvenioService, PacienteConvenioService>();
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IDentistaService, DentistaService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IExameService, ExameService>();
            services.AddScoped<IFuncionarioService, FuncionarioService>();
            services.AddScoped<IPacienteService, PacienteService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
