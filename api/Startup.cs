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
using SysDente.Models;
using SysDente.Contextos;
using SysDente.Repositorios;

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
            services.AddDbContext<DataContext>(options => options.UseSqlite(Configuration.GetConnectionString("ModelConnection")));

            services.AddMvc();
            services.AddScoped<IAgenda.cs, Agenda.cs>();
            services.AddScoped<IConvenio.cs, Convenio.cs>();
            services.AddScoped<IEmpresa.cs, Empresa.cs>();
            services.AddScoped<IEstado.cs, Estado.cs>();
            services.AddScoped<IFornecedor.cs, Fornecedor.cs>();
            services.AddScoped<IHistoricoPaciente.cs, HistoricoPaciente.cs>();
            services.AddScoped<IPacienteConvenio.cs, PacienteConvenio.cs>();
            services.AddScoped<ICidade.cs, Cidade.cs>();
            services.AddScoped<IDentista.cs, Dentista.cs>();
            services.AddScoped<IEndereco.cs, Endereco.cs>();
            services.AddScoped<IExame.cs, Exame.cs>();
            services.AddScoped<IFuncionario.cs, Funcionario.cs>();
            services.AddScoped<IModelsproj.cs, Modelsproj.cs>();
            services.AddScoped<IPaciente.cs, Paciente.cs>();
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
