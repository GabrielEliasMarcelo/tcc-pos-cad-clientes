namespace CadastroClientesServices.BizServices
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public class PessoaFisicaBizService : IPessoaFisicaBizService
	{
		private readonly IPessoaFisicaEntityService _iPessoaFisicaEntityService;

		public PessoaFisicaBizService(IPessoaFisicaEntityService pessoaFisicaEntityService)
		{
			_iPessoaFisicaEntityService = pessoaFisicaEntityService;
		}

		public bool CreatePessoaFisica(PessoaFisicaTO pessoaFisica)
		{
			throw new System.NotImplementedException();
		}

		public bool DeletePessoaFisica(int Id)
		{
			throw new System.NotImplementedException();
		}

		public List<PessoaFisicaTO> GetPessoaFisica()
		{
			throw new System.NotImplementedException();
		}

		public PessoaFisicaTO GetPessoaFisicaById(int Id)
		{
			throw new System.NotImplementedException();
		}

		public bool UpdatePessoaFisica(PessoaFisicaTO pessoaFisica)
		{
			throw new System.NotImplementedException();
		}
	}
}
