namespace CadastroClientesServices.EntityServices.Interfaces
{
	using CadastroClientesServices.Model;
	using System.Collections.Generic;

	public interface IPessoaJuridicaEntityService
	{
		public PessoaJuridica GetPessoaJuridicaById(int Id);

		public List<PessoaJuridica> GetPessoaJuridica();

		public bool CreatePessoaJuridica(PessoaJuridica pessoaJuridica);

		public bool UpdatePessoaJuridica(PessoaJuridica pessoaJuridica);

		public bool DeletePessoaJuridica(int Id);
	}
}
