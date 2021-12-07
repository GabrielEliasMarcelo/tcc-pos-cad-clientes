namespace CadastroClientesServices.EntityServices
{
    using CadastroClientesServices.EntityServices.Interfaces;
    using CadastroClientesServices.Model;
    using System.Collections.Generic;
    using System.Linq;

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
                _context.Enderecos.Add(endereco);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public int SaveEndereco(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();

            return endereco.Id;
        }

        public bool DeleteEndereco(int Id)
        {
            try
            {
                var enderecoAtualizar = _context.Enderecos.FirstOrDefault(c => c.Id == Id);
                enderecoAtualizar.Excluido = true;
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Endereco GetEnderecoById(int Id)
        {
            return _context.Enderecos.FirstOrDefault(c => c.Id == Id);
        }

        public List<Endereco> GetEnderecos()
        {
            return _context.Enderecos.ToList();
        }

        public bool UpdateEndereco(Endereco endereco)
        {
            try
            {
                var enderecoAtualizar = _context.Enderecos.FirstOrDefault(c => c.Id == endereco.Id);

                if (enderecoAtualizar != null)
                {
                    enderecoAtualizar.Id = endereco.Id;
                    enderecoAtualizar.Excluido = endereco.Excluido;
                    enderecoAtualizar.DataCadastro = endereco.DataCadastro;
                    enderecoAtualizar.DataAlteracao = endereco.DataAlteracao;
                    enderecoAtualizar.CodigoPostal = endereco.CodigoPostal;
                    enderecoAtualizar.InformacoesAdicionais = endereco.InformacoesAdicionais;
                    enderecoAtualizar.Pais = endereco.Pais;
                    enderecoAtualizar.Localizacao = endereco.Localizacao;

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
