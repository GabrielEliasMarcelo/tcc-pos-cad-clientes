namespace CadastroClientesServices.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Depositos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        [ForeignKey("Mercadorias")]
        public int IdMercadoria { get; set; }

        public virtual Mercadorias Mercadoria { get; set; }

        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }

        public virtual Endereco Endereco { get; set; }

        public bool Excluido { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}
