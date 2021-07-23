namespace CadastroClientesServices.BizServices
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.Extensions;
	using CadastroClientesServices.TO;

	public class EnderecoBizServices : IEnderecoBizServices
	{
		private readonly IEnderecoEntityServices _ienderecoEntityServices;

		public EnderecoBizServices(IEnderecoEntityServices enderecoEntityServices)
		{
			_ienderecoEntityServices = enderecoEntityServices;
		}

		public bool CreateEndereco(EnderecoTO enderecoTO)
		{
			return _ienderecoEntityServices.CreateEndereco(enderecoTO.ToEndereco());
		}
	}
}
