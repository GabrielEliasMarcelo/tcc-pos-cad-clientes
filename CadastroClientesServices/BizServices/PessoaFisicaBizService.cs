namespace CadastroClientesServices.BizServices
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.Extensions;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public class PessoaFisicaBizService : IPessoaFisicaBizService
	{
		private readonly IPessoaFisicaEntityService _iPessoaFisicaEntityService;
		private readonly IEnderecoEntityServices _enderecoEntityServices;

		public PessoaFisicaBizService(IPessoaFisicaEntityService pessoaFisicaEntityService, IEnderecoEntityServices enderecoEntityServices)
		{
			_iPessoaFisicaEntityService = pessoaFisicaEntityService;
			_enderecoEntityServices = enderecoEntityServices;
		}

		public bool CreatePessoaFisica(PessoaFisicaTO pessoaFisica)
		{
			pessoaFisica.IdEndereco = _enderecoEntityServices.SaveEndereco(pessoaFisica.Endereco.ToEndereco());
			return _iPessoaFisicaEntityService.CreatePessoaFisica(pessoaFisica.ToPF());
		}

		public bool DeletePessoaFisica(int Id)
		{
			return _iPessoaFisicaEntityService.DeletePessoaFisica(Id);
		}

		public List<PessoaFisicaTO> GetPessoasFisica()
		{
			return _iPessoaFisicaEntityService.GetPessoaFisica().ToLsPFTO();
		}

		public PessoaFisicaTO GetPessoaFisicaById(int Id)
		{
			return _iPessoaFisicaEntityService.GetPessoaFisicaById(Id).ToPFTO();
		}

		public bool UpdatePessoaFisica(PessoaFisicaTO pessoaFisica)
		{
			_enderecoEntityServices.UpdateEndereco(pessoaFisica.Endereco.ToEndereco());
			return _iPessoaFisicaEntityService.UpdatePessoaFisica(pessoaFisica.ToPF());
		}
	}
}
