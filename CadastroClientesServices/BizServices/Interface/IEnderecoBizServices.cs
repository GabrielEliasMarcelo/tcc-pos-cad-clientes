namespace CadastroClientesServices.BizServices.Interface
{
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public interface IEnderecoBizServices
	{
		public bool CreateEndereco(EnderecoTO enderecoTO);

		public EnderecoTO GetEnderecoById(int idEndereco);

		public List<EnderecoTO> GetEnderecos();

		public bool UpdateEndereco(EnderecoTO enderecoTO);

		public bool DeleteEnderco(int idEndereco);
	}
}
