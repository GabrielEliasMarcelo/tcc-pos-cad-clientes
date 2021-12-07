namespace CadastroClientesServices.EntityServices
{
	using CadastroClientesServices.EntityServices.Interfaces;
	using CadastroClientesServices.Model;
	using System.Collections.Generic;
	using System.Linq;

	public class PessoaJuridicaEntityService : IPessoaJuridicaEntityService
	{
		private readonly ClientesContext _context;

		public PessoaJuridicaEntityService(ClientesContext context)
		{
			_context = context;
		}

		public bool CreatePessoaJuridica(PessoaJuridica pessoaJuridica)
		{
			try
			{
				_context.PessoaJuridicas.Add(pessoaJuridica);
				_context.SaveChanges();
				return true;
			}
			catch
			{

				return false;
			}
		}

		public bool DeletePessoaJuridica(int Id)
		{
			try
			{
				var pessoaJuridica = _context.PessoaJuridicas.FirstOrDefault(c => c.Id == Id);
				pessoaJuridica.Excluido = true;
				_context.SaveChanges();
				return true;
			}
			catch
			{

				return false;
			}
		}

		public List<PessoaJuridica> GetPessoaJuridica()
		{
			return _context.PessoaJuridicas.ToList();
		}

		public PessoaJuridica GetPessoaJuridicaById(int Id)
		{
			return _context.PessoaJuridicas.FirstOrDefault(c => c.Id == Id);
		}

		public bool UpdatePessoaJuridica(PessoaJuridica pessoaJuridica)
		{
			try
			{
				var pj = _context.PessoaJuridicas.FirstOrDefault(c => c.Id == pessoaJuridica.Id);

				if (pj != null)
				{
					pj.Id = pessoaJuridica.Id;
					pj.NomeFantasia = pessoaJuridica.NomeFantasia;
					pj.IdEndereco = pessoaJuridica.IdEndereco;
					pj.Excluido = pessoaJuridica.Excluido;
					pj.EmailResposavel = pessoaJuridica.EmailResposavel;
					pj.DataCadastro = pessoaJuridica.DataCadastro;
					pj.DataAlteracao = pessoaJuridica.DataAlteracao;
					pj.CNPJ = pessoaJuridica.CNPJ;

					_context.SaveChanges();

					return true;
				}
                else
                {
					return false;
                }
			}
			catch
			{

				return false;
			}
		}
	}
}
