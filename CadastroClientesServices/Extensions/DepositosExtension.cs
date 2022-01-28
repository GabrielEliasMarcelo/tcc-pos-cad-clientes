namespace CadastroClientesServices.Extensions
{
    using CadastroClientesServices.Model;
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public static class DepositoExtension
    {
        public static Depositos ToDeposito(this DepositosTO depositoTO)
        {
            Depositos depositos = new Depositos();

            if (depositoTO.Id.HasValue)
                depositos.Id = depositoTO.Id.Value;

            if (depositoTO.Excluido.HasValue)
                depositos.Excluido = depositoTO.Excluido.Value;

            if (depositoTO.DataCadastro.HasValue)
                depositos.DataCadastro = depositoTO.DataCadastro.Value;

            if (depositoTO.DataAlteracao.HasValue)
                depositos.DataAlteracao = depositoTO.DataAlteracao.Value;

            if (depositoTO.IdMercadoria.HasValue)
                depositos.IdMercadoria = depositoTO.IdMercadoria.Value;

            if (depositoTO.IdEndereco.HasValue)
                depositos.IdEndereco = depositoTO.IdEndereco.Value;

            depositos.Nome = depositoTO.Nome;

            return depositos;
        }

        public static DepositosTO ToDepositoTO(this Depositos depositos)
        {
            DepositosTO depositoTO = new DepositosTO();

            depositoTO.Id = depositos.Id;
            depositoTO.Excluido = depositos.Excluido;
            depositoTO.DataCadastro = depositos.DataCadastro;
            depositoTO.DataAlteracao = depositos.DataAlteracao;
            depositoTO.IdMercadoria = depositos.IdMercadoria;
            depositoTO.IdEndereco = depositos.IdEndereco;
            depositoTO.Nome = depositos.Nome;

            return depositoTO;
        }

        public static List<DepositosTO> ToDepositoTO(this List<Depositos> lsDepositos)
        {
            List<DepositosTO> depositosTOs = new List<DepositosTO>();

            foreach (var depositos in lsDepositos)
            {
                DepositosTO depositoTO = new DepositosTO();
                depositoTO.Id = depositos.Id;
                depositoTO.Excluido = depositos.Excluido;
                depositoTO.DataCadastro = depositos.DataCadastro;
                depositoTO.DataAlteracao = depositos.DataAlteracao;
                depositoTO.IdMercadoria = depositos.IdMercadoria;
                depositoTO.IdEndereco = depositos.IdEndereco;
                depositoTO.Nome = depositos.Nome;

                depositosTOs.Add(depositoTO);
            }

            return depositosTOs;
        }
    }
}
