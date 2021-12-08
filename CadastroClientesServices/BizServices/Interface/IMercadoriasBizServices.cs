namespace CadastroClientesServices.BizServices.Interface
{
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public interface IMercadoriasBizServices
    {
        public bool CreateMercadorias(MercadoriasTO MercadoriasTO);

        public MercadoriasTO GetMercadoriasById(int idMercadorias);

        public List<MercadoriasTO> GetMercadoriass();

        public bool UpdateMercadorias(MercadoriasTO MercadoriasTO);

        public bool DeleteMercadorias(int idMercadorias);
    }
}