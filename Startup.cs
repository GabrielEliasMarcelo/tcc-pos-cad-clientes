namespace CadastroClientes
{
	using CadastroClientesServices.BizServices;
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.EntityServices;
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.Model;
	using Microsoft.AspNetCore.Builder;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Hosting;
	using Microsoft.Extensions.Logging;
	using Microsoft.OpenApi.Models;

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

			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "CadastroClientes", Version = "v1" });
			});

			//Temporario adicionar em um .config
			var connection = @"Server=(localdb)\mssqllocaldb;Database=Clientes;Trusted_Connection=True;";
			services.AddDbContext<ClientesContext>(options => options.UseSqlServer(connection));

			services.AddScoped<IEnderecoBizServices, EnderecoBizServices>();
			services.AddScoped<IEnderecoEntityServices, EnderecoEntityServices>();
			services.AddScoped<IPessoaFisicaBizService, PessoaFisicaBizService>();
			services.AddScoped<IPessoaFisicaEntityService, PessoaFisicaEntityServices>();

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CadastroClientes v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
