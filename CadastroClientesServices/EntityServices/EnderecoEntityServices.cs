namespace CadastroClientesServices.EntityServices
{
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.Model;
	using System;
	using System.Collections.Generic;

	public class EnderecoEntityServices : IEnderecoEntityServices
	{
		private readonly ClientesContext _context;

		public EnderecoEntityServices(ClientesContext context)
		{
			_context = context;
		}

		public bool CreateEndereco(Endereco endereco)
		{
			try
			{
				//TODO: Validar campos obrigatorios, adicionar uma info default
				_context.Enderecos.Add(endereco);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
				//TODO: Adicionar log4 net
			}

		}

		public bool DeleteEndereco(int Id)
		{
			throw new System.NotImplementedException();
		}

		public Endereco GetEnderecoById(int Id)
		{
			throw new System.NotImplementedException();
		}

		public List<Endereco> GetEnderecos()
		{
			throw new System.NotImplementedException();
		}

		public bool UpdateEndereco(Endereco endereco)
		{
			throw new System.NotImplementedException();
		}
	}
}

