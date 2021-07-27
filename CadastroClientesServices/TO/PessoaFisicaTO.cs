namespace CadastroClientesServices.TO
{
	using System;

	public class PessoaFisicaTO
	{
		public int? Id { get; set; }

		public string Nome { get; set; }

		public decimal? NumeroCPF { get; set; }

		public DateTime DataNascimento { get; set; }

		public string Email { get; set; }

		public int? IdEndereco { get; set; }

		public EnderecoTO Endereco { get; set; }

		public bool? Excluido { get; set; }

		public DateTime? DataCadastro { get; set; }

		public DateTime? DataAlteracao { get; set; }
	}
}
