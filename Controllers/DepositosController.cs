namespace CadastroClientes.Controllers
{
    using CadastroClientesServices.BizServices.Interface;
    using CadastroClientesServices.TO;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    [Route("api/[controller]")]
	[ApiController]
	public class DepositosController : Controller
    {
		private readonly IDepositosBizServices _idepositosBizServices;

		public DepositosController(IDepositosBizServices depositosBizServices)
		{
			_idepositosBizServices = depositosBizServices;
		}

		// GET: api/<DepositosController>
		[HttpGet]
		public List<DepositosTO> Get()
		{
			try
			{
				return _idepositosBizServices.GetDepositoss();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET api/<DepositosController>/5
		[HttpGet("{id}")]
		public DepositosTO Get(int id)
		{
			try
			{
				return _idepositosBizServices.GetDepositosById(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// POST api/<DepositosController>
		[HttpPost]
		public void Post([FromBody] DepositosTO DepositosDTO)
		{
			try
			{
				_idepositosBizServices.CreateDepositos(DepositosDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// PUT api/<DepositosController>/5
		[HttpPut]
		public void Put([FromBody] DepositosTO DepositosDTO)
		{
			try
			{
				_idepositosBizServices.UpdateDepositos(DepositosDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE api/<DepositosController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			try
			{
				_idepositosBizServices.DeleteDepositos(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
