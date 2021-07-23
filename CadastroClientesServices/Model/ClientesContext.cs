namespace CadastroClientesServices.Model
{
	using Microsoft.EntityFrameworkCore;

	public class ClientesContext : DbContext
	{
		public ClientesContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Endereco> Enderecos { get; set; }
		public DbSet<PessoaFisica> PessoaFisicas { get; set; }
		public DbSet<PessoaJuridica> PessoaJuridicas { get; set; }

	}
}
