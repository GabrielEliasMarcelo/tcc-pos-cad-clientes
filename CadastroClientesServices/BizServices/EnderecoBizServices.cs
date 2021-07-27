namespace CadastroClientesServices.BizServices
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.Extensions;
	using CadastroClientesServices.TO;
	using System.Collections.Generic;

	public class EnderecoBizServices : IEnderecoBizServices
	{
		private readonly IEnderecoEntityServices _iEnderecoEntityServices;

		public EnderecoBizServices(IEnderecoEntityServices enderecoEntityServices)
		{
			_iEnderecoEntityServices = enderecoEntityServices;
		}

		public bool CreateEndereco(EnderecoTO enderecoTO)
		{
			return _iEnderecoEntityServices.CreateEndereco(enderecoTO.ToEndereco());
		}

		public bool DeleteEnderco(int idEndereco)
		{
			return _iEnderecoEntityServices.DeleteEndereco(idEndereco);
		}

		public EnderecoTO GetEnderecoById(int idEndereco)
		{
			return _iEnderecoEntityServices.GetEnderecoById(idEndereco).ToEnderecoTO();
		}

		public List<EnderecoTO> GetEnderecos()
		{
			return _iEnderecoEntityServices.GetEnderecos().ToEnderecoTO();
		}

		public bool UpdateEndereco(EnderecoTO enderecoTO)
		{
			return _iEnderecoEntityServices.UpdateEndereco(enderecoTO.ToEndereco());
		}
	}
}
