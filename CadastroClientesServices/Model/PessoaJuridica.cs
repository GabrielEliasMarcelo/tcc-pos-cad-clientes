namespace CadastroClientesServices.Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class PessoaJuridica
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string NomeFantasia { get; set; }

		public string CNPJ { get; set; }

		public string EmailResposavel { get; set; }

		[ForeignKey("Endereco")]
		public int IdEndereco { get; set; }

		public virtual Endereco Endereco { get; set; }

		public bool Excluido { get; set; }

		public DateTime DataCadastro { get; set; }

		public DateTime DataAlteracao { get; set; }
	}
}
