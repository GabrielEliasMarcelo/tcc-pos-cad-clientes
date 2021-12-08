namespace CadastroClientesServices.TO
{
    using CadastroClientesServices.Model;
    using System;

    public class DepositosTO
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public int? IdMercadoria { get; set; }

        public virtual Mercadorias Mercadoria { get; set; }

        public int? IdEndereco { get; set; }

        public Endereco Endereco { get; set; }

        public bool? Excluido { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
