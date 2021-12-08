namespace CadastroClientesServices.BizServices.Interface
{
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public interface IFornecedoresBizServices
    {
        public bool CreateFornecedores(FornecedoresTO FornecedoresTO);

        public FornecedoresTO GetFornecedoresById(int idFornecedores);

        public List<FornecedoresTO> GetFornecedoress();

        public bool UpdateFornecedores(FornecedoresTO FornecedoresTO);

        public bool DeleteFornecedores(int idFornecedores);
    }
}
