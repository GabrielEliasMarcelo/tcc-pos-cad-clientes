namespace CadastroClientesServices.Extensions
{
	using CadastroClientesServices.Model;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public static class PessoaJuridicaExtension
	{

		public static PessoaJuridica ToPJ(this PessoaJuridicaTO pessoaJuridicaTO)
		{
			PessoaJuridica pj = new PessoaJuridica();
			pj.Id = pessoaJuridicaTO.Id.Value;
			pj.NomeFantasia = pessoaJuridicaTO.NomeFantasia;
			pj.IdEndereco = pessoaJuridicaTO.IdEndereco.Value;
			pj.Excluido = pessoaJuridicaTO.Excluido.Value;
			pj.EmailResposavel = pessoaJuridicaTO.EmailResposavel;
			pj.DataCadastro = pessoaJuridicaTO.DataCadastro.Value;
			pj.DataAlteracao = pessoaJuridicaTO.DataAlteracao.Value;
			pj.CNPJ = pessoaJuridicaTO.CNPJ;
		
			return pj;
		}

		public static List<PessoaJuridicaTO> ToLsPJ(this List<PessoaJuridica> pessoaJuridicaTOs)
		{
			List<PessoaJuridicaTO> pessoaJuridicas = new List<PessoaJuridicaTO>();

			foreach (var item in pessoaJuridicaTOs)
			{
				PessoaJuridicaTO pessoaJuridicaTO = new PessoaJuridicaTO();
				pessoaJuridicaTO.Id = item.Id;
				pessoaJuridicaTO.NomeFantasia = item.NomeFantasia;
				pessoaJuridicaTO.IdEndereco = item.IdEndereco;
				pessoaJuridicaTO.Excluido = item.Excluido;
				pessoaJuridicaTO.EmailResposavel = item.EmailResposavel;
				pessoaJuridicaTO.DataCadastro = item.DataCadastro;
				pessoaJuridicaTO.DataAlteracao = item.DataAlteracao;
				pessoaJuridicaTO.CNPJ = item.CNPJ;

				pessoaJuridicas.Add(pessoaJuridicaTO);
			}

			return pessoaJuridicas;
		}

		public static PessoaJuridicaTO ToPJTO(this PessoaJuridica pessoaJuridica)
		{
			PessoaJuridicaTO pessoaJuridicaTO = new PessoaJuridicaTO();
			pessoaJuridicaTO.Id = pessoaJuridica.Id;
			pessoaJuridicaTO.NomeFantasia = pessoaJuridica.NomeFantasia;
			pessoaJuridicaTO.IdEndereco = pessoaJuridica.IdEndereco;
			pessoaJuridicaTO.Excluido = pessoaJuridica.Excluido;
			pessoaJuridicaTO.EmailResposavel = pessoaJuridica.EmailResposavel;
			pessoaJuridicaTO.DataCadastro = pessoaJuridica.DataCadastro;
			pessoaJuridicaTO.DataAlteracao = pessoaJuridica.DataAlteracao;
			pessoaJuridicaTO.CNPJ = pessoaJuridica.CNPJ;

			return pessoaJuridicaTO;
		}
	}
}
