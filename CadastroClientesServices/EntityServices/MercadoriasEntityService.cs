namespace CadastroClientesServices.EntityServices
{
    using CadastroClientesServices.EntityServices.Interfaces;
    using CadastroClientesServices.Model;
    using System.Collections.Generic;
    using System.Linq;

    public class MercadoriasEntityService : IMercadoriasEntityService
    {
        private readonly ClientesContext _context;

        public MercadoriasEntityService(ClientesContext context)
        {
            _context = context;
        }

        public bool CreateMercadorias(Mercadorias mercadorias)
        {
            try
            {
                _context.Mercadorias.Add(mercadorias);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteMercadorias(int Id)
        {
            try
            {
                var depositos = _context.Mercadorias.FirstOrDefault(c => c.Id == Id);
                depositos.Excluido = true;
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Mercadorias GetMercadoriasById(int Id)
        {
            return _context.Mercadorias.FirstOrDefault(c => c.Id == Id);
        }

        public List<Mercadorias> GetMercadoriass()
        {
            return _context.Mercadorias.ToList();
        }

        public bool UpdateMercadorias(Mercadorias mercadoriasUpdate)
        {
            try
            {
                var mercadoria = _context.Mercadorias.FirstOrDefault(c => c.Id == mercadoriasUpdate.Id);

                mercadoria.Excluido = mercadoriasUpdate.Excluido;
                mercadoria.DataCadastro = mercadoriasUpdate.DataCadastro;
                mercadoria.DataAlteracao = mercadoriasUpdate.DataAlteracao;
                mercadoria.Excluido = mercadoriasUpdate.Excluido;
                mercadoria.Descricao = mercadoriasUpdate.Descricao;
                mercadoria.Valor = mercadoriasUpdate.Valor;

                _context.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
