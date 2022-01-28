namespace CadastroClientesServices.EntityServices
{
    using CadastroClientesServices.EntityServices.Interfaces;
    using CadastroClientesServices.Model;
    using System.Collections.Generic;
    using System.Linq;

    public class FornecedoresEntityService : IFornecedoresEntityService
    {
        private readonly ClientesContext _context;

        public FornecedoresEntityService(ClientesContext context)
        {
            _context = context;
        }

        public bool CreateFornecedores(Fornecedores fornecedores)
        {
            try
            {
                _context.Fornecedores.Add(fornecedores);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteFornecedores(int Id)
        {
            try
            {
                var fornecedore = _context.Fornecedores.FirstOrDefault(c => c.Id == Id);
                fornecedore.Excluido = true;
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Fornecedores GetFornecedoresById(int Id)
        {
            return _context.Fornecedores.FirstOrDefault(c => c.Id == Id);
        }

        public List<Fornecedores> GetFornecedoress()
        {
            return _context.Fornecedores.ToList();
        }

        public bool UpdateFornecedores(Fornecedores fornecedores)
        {
            try
            {
                var  fornecedorBD = _context.Fornecedores.FirstOrDefault(c => c.Id == fornecedores.Id);

                if (fornecedorBD != null)
                {
                    fornecedorBD.Id = fornecedores.Id;
                    fornecedorBD.Excluido = fornecedores.Excluido;
                    fornecedorBD.DataCadastro = fornecedores.DataCadastro;
                    fornecedorBD.DataAlteracao = fornecedores.DataAlteracao;
                    fornecedorBD.DadosComplementares = fornecedores.DadosComplementares;
                    fornecedorBD.IdPessoaFisica = fornecedores.IdPessoaFisica;
                    fornecedorBD.IdPessoaJuridica = fornecedores.IdPessoaJuridica;

                    _context.SaveChanges();
                }

                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
