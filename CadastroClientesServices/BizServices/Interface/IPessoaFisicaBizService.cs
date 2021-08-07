namespace CadastroClientesServices.BizServices.Interface
{
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public interface IPessoaFisicaBizService
	{
		public PessoaFisicaTO GetPessoaFisicaById(int Id);

		public List<PessoaFisicaTO> GetPessoasFisica();

		public bool CreatePessoaFisica(PessoaFisicaTO pessoaFisica);

		public bool UpdatePessoaFisica(PessoaFisicaTO pessoaFisica);

		public bool DeletePessoaFisica(int Id);
	}
}
