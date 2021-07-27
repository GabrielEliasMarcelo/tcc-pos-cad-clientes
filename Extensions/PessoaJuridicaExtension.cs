namespace CadastroClientes.Extensions
{
	using CadastroClientes.DTO;
	using System;

	public class PessoaJuridicaExtension
	{
		public int? Id { get; set; }

		public string NomeFantasia { get; set; }

		public string CNPJ { get; set; }

		public string EmailResposavel { get; set; }

		public int? IdEndereco { get; set; }

		public EnderecoDTO Endereco { get; set; }

		public bool? Excluido { get; set; }

		public DateTime? DataCadastro { get; set; }

		public DateTime? DataAlteracao { get; set; }
	}
}
