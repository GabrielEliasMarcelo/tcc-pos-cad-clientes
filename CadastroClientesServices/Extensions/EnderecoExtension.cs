namespace CadastroClientesServices.Extensions
{
	using CadastroClientesServices.Model;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public static class EnderecoExtension
	{
		public static Endereco ToEndereco(this EnderecoTO enderecoTO)
		{
			Endereco endereco = new Endereco();

			if (enderecoTO.Id.HasValue)
				endereco.Id = enderecoTO.Id.Value;

			if (enderecoTO.Excluido.HasValue)
				endereco.Excluido = enderecoTO.Excluido.Value;

			if (enderecoTO.DataCadastro.HasValue)
				endereco.DataCadastro = enderecoTO.DataCadastro.Value;

			if (enderecoTO.DataAlteracao.HasValue)
				endereco.DataAlteracao = enderecoTO.DataAlteracao.Value;

			endereco.CodigoPostal = enderecoTO.CodigoPostal;
			endereco.InformacoesAdicionais = enderecoTO.InformacoesAdicionais;
			endereco.Pais = enderecoTO.Pais;
			endereco.Localizacao = enderecoTO.Localizacao;

			return endereco;
		}

		public static EnderecoTO ToEnderecoTO(this Endereco endereco)
		{
			EnderecoTO enderecoTO = new EnderecoTO();
			enderecoTO.Id = endereco.Id;
			enderecoTO.Excluido = endereco.Excluido;
			enderecoTO.DataCadastro = endereco.DataCadastro;
			enderecoTO.DataAlteracao = endereco.DataAlteracao;
			enderecoTO.CodigoPostal = endereco.CodigoPostal;
			enderecoTO.InformacoesAdicionais = endereco.InformacoesAdicionais;
			enderecoTO.Pais = endereco.Pais;
			enderecoTO.Localizacao = endereco.Localizacao;

			return enderecoTO;
		}

		public static List<EnderecoTO> ToEnderecoTO (this List<Endereco> lsEnderecos)
		{
			List<EnderecoTO> enderecoTOs = new List<EnderecoTO>();
			foreach (var endereco in lsEnderecos)
			{
				EnderecoTO enderecoTO = new EnderecoTO();
				enderecoTO.Id = endereco.Id;
				enderecoTO.Excluido = endereco.Excluido;
				enderecoTO.DataCadastro = endereco.DataCadastro;
				enderecoTO.DataAlteracao = endereco.DataAlteracao;
				enderecoTO.CodigoPostal = endereco.CodigoPostal;
				enderecoTO.InformacoesAdicionais = endereco.InformacoesAdicionais;
				enderecoTO.Pais = endereco.Pais;
				enderecoTO.Localizacao = endereco.Localizacao;

				enderecoTOs.Add(enderecoTO);
			}

			return enderecoTOs;
		}
	}
}