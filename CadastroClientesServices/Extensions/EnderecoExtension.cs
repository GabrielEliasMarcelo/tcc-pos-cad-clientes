namespace CadastroClientesServices.Extensions
{
	using CadastroClientesServices.Model;
	using CadastroClientesServices.TO;

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
	}
}