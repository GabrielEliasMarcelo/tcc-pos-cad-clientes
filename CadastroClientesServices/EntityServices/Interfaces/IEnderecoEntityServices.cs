namespace CadastroClientesServices.EntityServices.Interfaces
{
	using CadastroClientesServices.Model;
	using System.Collections.Generic;

	public interface IEnderecoEntityServices
	{
		public Endereco GetEnderecoById(int Id);

		public List<Endereco> GetEnderecos();

		public bool CreateEndereco(Endereco endereco);

		public bool UpdateEndereco(Endereco endereco);

		public bool ExcluirEndereco(int Id);

	}
}
