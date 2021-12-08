namespace CadastroClientesServices.EntityServices
{
    using CadastroClientesServices.EntityServices.Interfaces;
    using CadastroClientesServices.Model;
    using System.Collections.Generic;

    public class DepositosEntityService : IDepositosEntityService
    {
        private readonly ClientesContext _context;

        public DepositosEntityService(ClientesContext context)
        {
            _context = context;
        }

        public bool CreateDepositos(Depositos Depositos)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteDepositos(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Depositos GetDepositosById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Depositos> GetDepositoss()
        {
            throw new System.NotImplementedException();
        }

        public int SaveDepositos(Depositos Depositos)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateDepositos(Depositos Depositos)
        {
            throw new System.NotImplementedException();
        }
    }
}
