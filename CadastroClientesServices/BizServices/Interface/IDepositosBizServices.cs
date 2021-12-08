namespace CadastroClientesServices.BizServices.Interface
{
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public interface IDepositosBizServices
    {
        public bool CreateDepositos(DepositosTO DepositosTO);

        public DepositosTO GetDepositosById(int idDepositos);

        public List<DepositosTO> GetDepositoss();

        public bool UpdateDepositos(DepositosTO DepositosTO);

        public bool DeleteDepositos(int idDepositos);
    }
}