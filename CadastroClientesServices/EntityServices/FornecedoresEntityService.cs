namespace CadastroClientesServices.EntityServices
{
    using CadastroClientesServices.EntityServices.Interfaces;
    using CadastroClientesServices.Model;
    using System.Collections.Generic;

    public class FornecedoresEntityService : IFornecedoresEntityService
    {
        private readonly ClientesContext _context;

        public FornecedoresEntityService(ClientesContext context)
        {
            _context = context;
        }

        public bool CreateFornecedores(Fornecedores Fornecedores)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteFornecedores(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Fornecedores GetFornecedoresById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Fornecedores> GetFornecedoress()
        {
            throw new System.NotImplementedException();
        }

        public int SaveFornecedores(Fornecedores Fornecedores)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateFornecedores(Fornecedores Fornecedores)
        {
            throw new System.NotImplementedException();
        }
    }
}
