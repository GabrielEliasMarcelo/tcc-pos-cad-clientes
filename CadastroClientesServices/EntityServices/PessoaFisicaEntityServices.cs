using CadastroClientesServices.EntityServices.Interfaces;
using CadastroClientesServices.Model;
using System.Collections.Generic;
using System.Linq;

namespace CadastroClientesServices.EntityServices
{
	public class PessoaFisicaEntityServices : IPessoaFisicaEntityService
	{
		private readonly ClientesContext _context;

		public PessoaFisicaEntityServices(ClientesContext context)
		{
			_context = context;
		}

		public bool CreatePessoaFisica(PessoaFisica pessoaFisica)
		{
			try
			{
				if (!validaPessoaFisica(pessoaFisica))
				{
					_context.PessoaFisicas.Add(pessoaFisica);
					_context.SaveChanges();

					return true;
				}
				else
				{
					// return mensagem
					return false;
				}
			}
			catch
			{
				return false;
			}
		}

		public bool DeletePessoaFisica(int Id)
		{
			try
			{
				var pessoaFisica = _context.PessoaFisicas.FirstOrDefault(c => c.Id == Id);
				pessoaFisica.Excluido = true;
				_context.SaveChanges();

				return true;
			}
			catch
			{
				return false;
			}
		}

		public List<PessoaFisica> GetPessoaFisica()
		{
			return _context.PessoaFisicas.ToList();
		}

		public PessoaFisica GetPessoaFisicaById(int Id)
		{
			return _context.PessoaFisicas.FirstOrDefault(c => c.Id == Id);
		}

		public bool UpdatePessoaFisica(PessoaFisica pessoaFisica)
		{
			try
			{
				var pf = _context.PessoaFisicas.FirstOrDefault(c => c.Id == pessoaFisica.Id);

				pf.Nome = pessoaFisica.Nome;
				pf.Email = pessoaFisica.Email;
				pf.DataNascimento = pessoaFisica.DataNascimento;
				pf.IdEndereco = pessoaFisica.IdEndereco;
				pf.DataCadastro = pessoaFisica.DataCadastro;
				pf.DataAlteracao = pessoaFisica.DataAlteracao;
				pf.Excluido = pessoaFisica.Excluido;
				pf.NumeroCPF = pessoaFisica.NumeroCPF;

				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		private bool validaPessoaFisica(PessoaFisica pessoaFisica)
		{
			var pessoas = _context.PessoaFisicas.Where(a => a.NumeroCPF == pessoaFisica.NumeroCPF).ToList();

			return pessoas.Count() > 0;
		}

	}
}
