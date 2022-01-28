namespace CadastroClientesServices.EntityServices.Interfaces
{
	using CadastroClientesServices.Model;
	using System.Collections.Generic;

	public interface IMercadoriasEntityService
    {
		public Mercadorias GetMercadoriasById(int Id);

		public List<Mercadorias> GetMercadoriass();

		public bool CreateMercadorias(Mercadorias Mercadorias);

		public bool UpdateMercadorias(Mercadorias Mercadorias);

		public bool DeleteMercadorias(int Id);

	}
}
