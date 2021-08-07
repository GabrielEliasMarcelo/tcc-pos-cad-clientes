namespace CadastroClientesServices.Extensions
{
	using CadastroClientesServices.Model;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public static class PessoaFisicaExtension
	{
		public static PessoaFisica ToPF(this PessoaFisicaTO pessoaFisicaTO)
		{
			PessoaFisica pessoaFisica = new PessoaFisica();
			pessoaFisica.Id = pessoaFisicaTO.Id.Value;
			pessoaFisica.Nome = pessoaFisicaTO.Nome;
			pessoaFisica.Email = pessoaFisicaTO.Email;
			pessoaFisica.DataNascimento = pessoaFisicaTO.DataNascimento;
			pessoaFisica.IdEndereco = pessoaFisicaTO.IdEndereco.Value;
			pessoaFisica.DataCadastro = pessoaFisicaTO.DataCadastro.Value;
			pessoaFisica.DataAlteracao = pessoaFisicaTO.DataAlteracao.Value;
			pessoaFisica.Excluido = pessoaFisicaTO.Excluido.Value;
			pessoaFisica.NumeroCPF = pessoaFisicaTO.NumeroCPF.Value;

			return pessoaFisica;
		}

		public static List<PessoaFisicaTO> ToLsPFTO (this List<PessoaFisica> pessoasFisica)
		{
			List<PessoaFisicaTO> pessoaFisicasTO = new List<PessoaFisicaTO>();

			foreach (var item in pessoasFisica)
			{
				var pfTo = new PessoaFisicaTO();

				pfTo.Nome = item.Nome;
				pfTo.Email = item.Email;
				pfTo.DataNascimento = item.DataNascimento;
				pfTo.IdEndereco = item.IdEndereco;
				pfTo.DataCadastro = item.DataCadastro;
				pfTo.DataAlteracao = item.DataAlteracao;
				pfTo.Excluido = item.Excluido;
				pfTo.NumeroCPF = item.NumeroCPF;

				pessoaFisicasTO.Add(pfTo);
			}

			return pessoaFisicasTO;
		}

		public static PessoaFisicaTO ToPFTO(this PessoaFisica pessoaFisica)
		{
			PessoaFisicaTO pessoaFisicaTO = new PessoaFisicaTO();
			pessoaFisicaTO.Id = pessoaFisica.Id;
			pessoaFisicaTO.Nome = pessoaFisica.Nome;
			pessoaFisicaTO.Email = pessoaFisica.Email;
			pessoaFisicaTO.DataNascimento = pessoaFisica.DataNascimento;
			pessoaFisicaTO.IdEndereco = pessoaFisica.IdEndereco;
			pessoaFisicaTO.DataCadastro = pessoaFisica.DataCadastro;
			pessoaFisicaTO.DataAlteracao = pessoaFisica.DataAlteracao;
			pessoaFisicaTO.Excluido = pessoaFisica.Excluido;
			pessoaFisicaTO.NumeroCPF = pessoaFisica.NumeroCPF;

			return pessoaFisicaTO;
		}
	}
}
