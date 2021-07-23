namespace CadastroClientes.Extensions
{
	using CadastroClientes.DTO;
	using CadastroClientesServices.TO;

	public static class EnderecoExtension
	{
		public static EnderecoTO ToEndereco(this EnderecoDTO enderecoDTO)
		{
			EnderecoTO enderecoTO = new EnderecoTO();
			enderecoTO.Id = enderecoDTO.Id;
			enderecoTO.Excluido = enderecoDTO.Excluido.Value;
			enderecoTO.DataCadastro = enderecoDTO.DataCadastro.Value;
			enderecoTO.DataAlteracao = enderecoDTO.DataAlteracao.Value;
			enderecoTO.CodigoPostal = enderecoDTO.CodigoPostal;
			enderecoTO.InformacoesAdicionais = enderecoDTO.InformacoesAdicionais;
			enderecoTO.Pais = enderecoDTO.Pais;
			enderecoTO.Localizacao = enderecoDTO.Localizacao;

			return enderecoTO;
		}
	}
}
