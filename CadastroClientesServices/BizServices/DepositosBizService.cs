namespace CadastroClientesServices.BizServices
{
    using CadastroClientesServices.BizServices.Interface;
    using CadastroClientesServices.EntityServices;
    using CadastroClientesServices.Extensions;
    using CadastroClientesServices.TO;
    using System.Collections.Generic;

    public class DepositosBizService : IDepositosBizServices
    {
        private readonly DepositosEntityService _depositosEntityService;

        public DepositosBizService(DepositosEntityService depositosEntityService)
        {
            _depositosEntityService = depositosEntityService;
        }

        public bool CreateDepositos(DepositosTO depositosTO)
        {
            return _depositosEntityService.CreateDepositos(depositosTO.ToDeposito());
        }

        public bool DeleteDepositos(int idDepositos)
        {
            return _depositosEntityService.DeleteDepositos(idDepositos);
        }
        public DepositosTO GetDepositosById(int idDepositos)
        {
            return _depositosEntityService.GetDepositosById(idDepositos).ToDepositoTO();
        }

        public List<DepositosTO> GetDepositoss()
        {
            return _depositosEntityService.GetDepositoss().ToDepositoTO();
        }

        public bool UpdateDepositos(DepositosTO depositosTO)
        {
            return _depositosEntityService.UpdateDepositos(depositosTO.ToDeposito());
        }
    }
}
