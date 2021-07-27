namespace CadastroClientesServices.BizServices
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public class PessoaJuridicaBizServices : IPessoaJuridicaBizService
	{
		private readonly IPessoaJuridicaEntityService _iPessoaJuridicaEntityService;

		public PessoaJuridicaBizServices(IPessoaJuridicaEntityService pessoaJuridicaEntityService)
		{
			_iPessoaJuridicaEntityService = pessoaJuridicaEntityService;
		}

		public bool CreatePessoaJuridica(PessoaJuridicaTO pessoaJuridica)
		{
			throw new System.NotImplementedException();
		}

		public bool DeletePessoaJuridica(int Id)
		{
			throw new System.NotImplementedException();
		}

		public List<PessoaJuridicaTO> GetPessoaJuridica()
		{
			throw new System.NotImplementedException();
		}

		public PessoaJuridicaTO GetPessoaJuridicaById(int Id)
		{
			throw new System.NotImplementedException();
		}

		public bool UpdatePessoaJuridica(PessoaJuridicaTO pessoaJuridica)
		{
			throw new System.NotImplementedException();
		}
	}
}
