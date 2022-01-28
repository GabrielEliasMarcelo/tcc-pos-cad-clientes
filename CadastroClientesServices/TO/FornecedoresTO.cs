namespace CadastroClientesServices.TO
{
    using CadastroClientesServices.Model;
    using System;

    public class FornecedoresTO
    {
        public int? Id { get; set; }

        public string DadosComplementares { get; set; }

        public int? IdPessoaFisica { get; set; }

        public PessoaFisica PessoaFisica { get; set; }

        public int? IdPessoaJuridica { get; set; }

        public PessoaJuridica PessoaJuridica { get; set; }

        public bool? Excluido { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
