namespace CadastroClientesServices.BizServices
{
    using CadastroClientesServices.BizServices.Interface;
    using CadastroClientesServices.EntityServices.Interfaces;
    using CadastroClientesServices.Extensions;
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public class MercadoriasBizService : IMercadoriasBizServices
    {
		private readonly IMercadoriasEntityService _iMercadoriasEntityServices;

		public MercadoriasBizService(IMercadoriasEntityService mercadoriasEntityServices)
		{
			_iMercadoriasEntityServices = mercadoriasEntityServices;
		}

		public bool CreateMercadorias(MercadoriasTO mercadoriasTO)
		{
			return _iMercadoriasEntityServices.CreateMercadorias(mercadoriasTO.ToMercadoria());
		}

		public bool DeleteMercadorias(int idMercadorias)
		{
			return _iMercadoriasEntityServices.DeleteMercadorias(idMercadorias);
		}

		public MercadoriasTO GetMercadoriasById(int idMercadorias)
		{
			return _iMercadoriasEntityServices.GetMercadoriasById(idMercadorias).ToMercadoriaTO();
		}

		public List<MercadoriasTO> GetMercadoriass()
		{
			return _iMercadoriasEntityServices.GetMercadoriass().ToMercadoriaTO();
		}

		public bool UpdateMercadorias(MercadoriasTO mercadoriasTO)
		{
			return _iMercadoriasEntityServices.UpdateMercadorias(mercadoriasTO.ToMercadoria());
		}
	}
}
