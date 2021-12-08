namespace CadastroClientesServices.EntityServices.Interfaces
{
	using CadastroClientesServices.Model;
	using System.Collections.Generic;

	public interface IDepositosEntityService
    {
		public Depositos GetDepositosById(int Id);

		public List<Depositos> GetDepositoss();

		public bool CreateDepositos(Depositos Depositos);

		public bool UpdateDepositos(Depositos Depositos);

		public bool DeleteDepositos(int Id);

		public int SaveDepositos(Depositos Depositos);
	}
}
