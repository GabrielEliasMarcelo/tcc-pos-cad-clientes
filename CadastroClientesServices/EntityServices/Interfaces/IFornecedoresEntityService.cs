namespace CadastroClientesServices.EntityServices.Interfaces
{
	using CadastroClientesServices.Model;
	using System.Collections.Generic;

	public interface IFornecedoresEntityService
    {
		public Fornecedores GetFornecedoresById(int Id);

		public List<Fornecedores> GetFornecedoress();

		public bool CreateFornecedores(Fornecedores Fornecedores);

		public bool UpdateFornecedores(Fornecedores Fornecedores);

		public bool DeleteFornecedores(int Id);

		public int SaveFornecedores(Fornecedores Fornecedores);
	}
}