namespace CadastroClientesServices.BizServices.Interface
{
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public interface IPessoaJuridicaBizService
	{
		public PessoaJuridicaTO GetPessoaJuridicaById(int Id);

		public List<PessoaJuridicaTO> GetPessoaJuridica();

		public bool CreatePessoaJuridica(PessoaJuridicaTO pessoaJuridica);

		public bool UpdatePessoaJuridica(PessoaJuridicaTO pessoaJuridica);

		public bool DeletePessoaJuridica(int Id);
	}
}
