namespace CadastroClientesServices.Extensions
{
    using CadastroClientesServices.Model;
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public static class FornecedoresExtension
    {
        public static Fornecedores ToFornecedores(this FornecedoresTO fornecedoresTO)
        {
            Fornecedores fornecedores = new Fornecedores();

            if (fornecedoresTO.Id.HasValue)
                fornecedores.Id = fornecedoresTO.Id.Value;

            if (fornecedoresTO.Excluido.HasValue)
                fornecedores.Excluido = fornecedoresTO.Excluido.Value;

            if (fornecedoresTO.DataCadastro.HasValue)
                fornecedores.DataCadastro = fornecedoresTO.DataCadastro.Value;

            if (fornecedoresTO.DataAlteracao.HasValue)
                fornecedores.DataAlteracao = fornecedoresTO.DataAlteracao.Value;

            fornecedores.IdPessoaFisica = fornecedoresTO.IdPessoaFisica;
            fornecedores.IdPessoaJuridica = fornecedoresTO.IdPessoaJuridica;
            fornecedores.DadosComplementares = fornecedoresTO.DadosComplementares;

            return fornecedores;
        }

        public static FornecedoresTO ToFornecedoresTO(this Fornecedores fornecedores)
        {
            FornecedoresTO fornecedoresTO = new FornecedoresTO();
            fornecedoresTO.Id = fornecedores.Id;
            fornecedoresTO.Excluido = fornecedores.Excluido;
            fornecedoresTO.DataCadastro = fornecedores.DataCadastro;
            fornecedoresTO.DataAlteracao = fornecedores.DataAlteracao;
            fornecedoresTO.DadosComplementares = fornecedores.DadosComplementares;
            fornecedoresTO.IdPessoaFisica = fornecedores.IdPessoaFisica;
            fornecedoresTO.IdPessoaJuridica = fornecedores.IdPessoaJuridica;

            return fornecedoresTO;
        }

        public static List<FornecedoresTO> ToFornecedoresTO(this List<Fornecedores> lsfornecedoress)
        {
            List<FornecedoresTO> fornecedoresTOs = new List<FornecedoresTO>();
            foreach (var fornecedores in lsfornecedoress)
            {
                FornecedoresTO fornecedoresTO = new FornecedoresTO();
                fornecedoresTO.Id = fornecedores.Id;
                fornecedoresTO.Excluido = fornecedores.Excluido;
                fornecedoresTO.DataCadastro = fornecedores.DataCadastro;
                fornecedoresTO.DataAlteracao = fornecedores.DataAlteracao;
                fornecedoresTO.DadosComplementares = fornecedores.DadosComplementares;
                fornecedoresTO.IdPessoaFisica = fornecedores.IdPessoaFisica;
                fornecedoresTO.IdPessoaJuridica = fornecedores.IdPessoaJuridica;

                fornecedoresTOs.Add(fornecedoresTO);
            }

            return fornecedoresTOs;
        }
    }
}
