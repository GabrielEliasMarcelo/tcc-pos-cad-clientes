namespace CadastroClientesServices.BizServices
{
    using CadastroClientesServices.BizServices.Interface;
    using CadastroClientesServices.EntityServices.Interfaces;
    using CadastroClientesServices.Extensions;
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public class FornecedoresBizService : IFornecedoresBizServices
    {
        private readonly IFornecedoresEntityService _fornecedoresEntityServoces;

        public FornecedoresBizService(IFornecedoresEntityService fornecedoresEntityService)
        {
            _fornecedoresEntityServoces = fornecedoresEntityService;
        }

        public bool CreateFornecedores(FornecedoresTO fornecedoresTO)
        {
            return _fornecedoresEntityServoces.CreateFornecedores(fornecedoresTO.ToFornecedores());
        }

        public bool DeleteFornecedores(int idFornecedores)
        {
            return _fornecedoresEntityServoces.DeleteFornecedores(idFornecedores);
        }

        public FornecedoresTO GetFornecedoresById(int idFornecedores)
        {
            return _fornecedoresEntityServoces.GetFornecedoresById(idFornecedores).ToFornecedoresTO();

        }

        public List<FornecedoresTO> GetFornecedoress()
        {
            return _fornecedoresEntityServoces.GetFornecedoress().ToFornecedoresTO();
        }

        public bool UpdateFornecedores(FornecedoresTO fornecedoresTO)
        {
            return _fornecedoresEntityServoces.UpdateFornecedores(fornecedoresTO.ToFornecedores());
        }
    }
}
