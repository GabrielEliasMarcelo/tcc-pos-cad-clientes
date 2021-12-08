namespace CadastroClientesServices.TO
{
    using System;

    public class MercadoriasTO
    {
        public int? Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public bool Excluido { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
