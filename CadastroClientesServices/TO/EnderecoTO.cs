namespace CadastroClientesServices.TO
{
	using System;

	public class EnderecoTO
	{
		public int? Id { get; set; }

		public string Pais { get; set; }

		public string CodigoPostal { get; set; }

		public string Localizacao { get; set; }

		public string InformacoesAdicionais { get; set; }

		public bool? Excluido { get; set; }

		public DateTime? DataCadastro { get; set; }

		public DateTime? DataAlteracao { get; set; }
	}
}
