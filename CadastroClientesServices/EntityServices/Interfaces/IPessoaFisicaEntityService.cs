namespace CadastroClientesServices.EntityServices.Interfaces
{
	using CadastroClientesServices.Model;
	using System.Collections.Generic;

	public interface IPessoaFisicaEntityService
	{
		public PessoaFisica GetPessoaFisicaById(int Id);

		public List<PessoaFisica> GetPessoaFisica();

		public bool CreatePessoaFisica(PessoaFisica pessoaFisica);

		public bool UpdatePessoaFisica(PessoaFisica pessoaFisica);

		public bool DeletePessoaFisica(int Id);
	}
}
