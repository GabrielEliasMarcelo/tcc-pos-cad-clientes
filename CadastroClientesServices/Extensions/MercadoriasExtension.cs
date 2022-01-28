namespace CadastroClientesServices.Extensions
{
    using CadastroClientesServices.Model;
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public static class MercadoriasExtension
    {
        public static Mercadorias ToMercadoria(this MercadoriasTO mercadoriaTO)
        {
            Mercadorias mercadorias = new Mercadorias();

            if (mercadoriaTO.Id.HasValue)
                mercadorias.Id = mercadoriaTO.Id.Value;
               
            if (mercadoriaTO.DataCadastro.HasValue)
                mercadorias.DataCadastro = mercadoriaTO.DataCadastro.Value;

            if (mercadoriaTO.DataAlteracao.HasValue)
                mercadorias.DataAlteracao = mercadoriaTO.DataAlteracao.Value;

            mercadorias.Excluido = mercadoriaTO.Excluido;
            mercadorias.Descricao = mercadoriaTO.Descricao;
            mercadorias.Valor = mercadoriaTO.Valor;

            return mercadorias;
        }

        public static MercadoriasTO ToMercadoriaTO(this Mercadorias mercadorias)
        {
            MercadoriasTO mercadoriaTO = new MercadoriasTO();

            mercadoriaTO.Id = mercadorias.Id;
            mercadoriaTO.Excluido = mercadorias.Excluido;
            mercadoriaTO.DataCadastro = mercadorias.DataCadastro;
            mercadoriaTO.DataAlteracao = mercadorias.DataAlteracao;
            mercadoriaTO.Excluido = mercadorias.Excluido;
            mercadoriaTO.Descricao = mercadorias.Descricao;
            mercadoriaTO.Valor = mercadorias.Valor;

            return mercadoriaTO;
        }

        public static List<MercadoriasTO> ToMercadoriaTO(this List<Mercadorias> lsMercadorias)
        {
            List<MercadoriasTO> mercadoriasTOs = new List<MercadoriasTO>();

            foreach (var mercadorias in lsMercadorias)
            {
                MercadoriasTO mercadoriaTO = new MercadoriasTO();

                mercadoriaTO.Id = mercadorias.Id;
                mercadoriaTO.Excluido = mercadorias.Excluido;
                mercadoriaTO.DataCadastro = mercadorias.DataCadastro;
                mercadoriaTO.DataAlteracao = mercadorias.DataAlteracao;
                mercadoriaTO.Excluido = mercadorias.Excluido;
                mercadoriaTO.Descricao = mercadorias.Descricao;
                mercadoriaTO.Valor = mercadorias.Valor;

                mercadoriasTOs.Add(mercadoriaTO);
            }

            return mercadoriasTOs;
        }
    }
}
