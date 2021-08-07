namespace CadastroClientesServices.BizServices
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.Extensions;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public class PessoaJuridicaBizServices : IPessoaJuridicaBizService
	{
		private readonly IPessoaJuridicaEntityService _pessoaJuridicaEntityService;
		private readonly IEnderecoEntityServices _enderecoEntityServices;

		public PessoaJuridicaBizServices(IPessoaJuridicaEntityService pessoaJuridicaEntityService, IEnderecoEntityServices enderecoEntityServices)
		{
			_pessoaJuridicaEntityService = pessoaJuridicaEntityService;
			_enderecoEntityServices = enderecoEntityServices;
		}

		public bool CreatePessoaJuridica(PessoaJuridicaTO pessoaJuridica)
		{
			pessoaJuridica.IdEndereco = _enderecoEntityServices.SaveEndereco(pessoaJuridica.Endereco.ToEndereco());

			return _pessoaJuridicaEntityService.CreatePessoaJuridica(pessoaJuridica.ToPJ());
		}

		public bool DeletePessoaJuridica(int Id)
		{
			return _pessoaJuridicaEntityService.DeletePessoaJuridica(Id);
		}

		public List<PessoaJuridicaTO> GetPessoaJuridica()
		{
			return _pessoaJuridicaEntityService.GetPessoaJuridica().ToLsPJ();
		}

		public PessoaJuridicaTO GetPessoaJuridicaById(int Id)
		{
			return _pessoaJuridicaEntityService.GetPessoaJuridicaById(Id).ToPJTO();
		}

		public bool UpdatePessoaJuridica(PessoaJuridicaTO pessoaJuridica)
		{
			 _enderecoEntityServices.UpdateEndereco(pessoaJuridica.Endereco.ToEndereco());
			return _pessoaJuridicaEntityService.UpdatePessoaJuridica(pessoaJuridica.ToPJ());
		}
	}
}
