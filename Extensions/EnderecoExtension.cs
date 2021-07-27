namespace CadastroClientes.Extensions
{
	using CadastroClientes.DTO;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public static class EnderecoExtension
	{
		public static EnderecoTO ToEnderecoTO(this EnderecoDTO enderecoDTO)
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

		public static EnderecoDTO ToDto(this EnderecoTO enderecoTO)
		{
			EnderecoDTO enderecoDTO = new EnderecoDTO();
			enderecoDTO.Id = enderecoTO.Id;
			enderecoDTO.Excluido = enderecoTO.Excluido.Value;
			enderecoDTO.DataCadastro = enderecoTO.DataCadastro.Value;
			enderecoDTO.DataAlteracao = enderecoTO.DataAlteracao.Value;
			enderecoDTO.CodigoPostal = enderecoTO.CodigoPostal;
			enderecoDTO.InformacoesAdicionais = enderecoTO.InformacoesAdicionais;
			enderecoDTO.Pais = enderecoTO.Pais;
			enderecoDTO.Localizacao = enderecoTO.Localizacao;

			return enderecoDTO;
		}

		public static List<EnderecoDTO> ToDto(this List<EnderecoTO> enderecosTO)
		{
			List<EnderecoDTO> lsEnderecosDTO = new List<EnderecoDTO>();

			foreach (var enderecoTO in enderecosTO)
			{
				EnderecoDTO enderecoDTO = new EnderecoDTO();
				enderecoDTO.Id = enderecoTO.Id;
				enderecoDTO.Excluido = enderecoTO.Excluido.Value;
				enderecoDTO.DataCadastro = enderecoTO.DataCadastro.Value;
				enderecoDTO.DataAlteracao = enderecoTO.DataAlteracao.Value;
				enderecoDTO.CodigoPostal = enderecoTO.CodigoPostal;
				enderecoDTO.InformacoesAdicionais = enderecoTO.InformacoesAdicionais;
				enderecoDTO.Pais = enderecoTO.Pais;
				enderecoDTO.Localizacao = enderecoTO.Localizacao;

				lsEnderecosDTO.Add(enderecoDTO);
			}

			return lsEnderecosDTO;
		}
	}
}
