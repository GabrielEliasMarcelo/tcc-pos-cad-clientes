namespace CadastroClientesServices.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Fornecedores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string DadosComplementares { get; set; }

        [ForeignKey("PessoaFisica")]
        public int? IdPessoaFisica { get; set; }

        public virtual PessoaFisica PessoaFisica { get; set; }

        [ForeignKey("PessoaJuridica")]
        public int? IdPessoaJuridica { get; set; }

        public virtual PessoaJuridica PessoaJuridica { get; set; }

        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }

        public virtual Endereco Endereco { get; set; }

        public bool Excluido { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

    }
}
