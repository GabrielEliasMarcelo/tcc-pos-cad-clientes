namespace CadastroClientesServices.EntityServices
{
    using CadastroClientesServices.EntityServices.Interfaces;
    using CadastroClientesServices.Model;
    using System.Collections.Generic;

    public class MercadoriasEntityService : IMercadoriasEntityService
    {
        private readonly ClientesContext _context;

        public MercadoriasEntityService(ClientesContext context)
        {
            _context = context;
        }

        public bool CreateMercadorias(Mercadorias Mercadorias)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteMercadorias(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Mercadorias GetMercadoriasById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Mercadorias> GetMercadoriass()
        {
            throw new System.NotImplementedException();
        }

        public int SaveMercadorias(Mercadorias Mercadorias)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateMercadorias(Mercadorias Mercadorias)
        {
            throw new System.NotImplementedException();
        }
    }
}
