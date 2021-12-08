namespace CadastroClientes.Controllers
{
    using CadastroClientesServices.BizServices.Interface;
    using CadastroClientesServices.TO;
    using Microsoft.AspNetCore.Mvc;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;

	public class FornecedoresController : Controller
    {
		private readonly IFornecedoresBizServices _ifornecedoresBizServices;

		public FornecedoresController(IFornecedoresBizServices fornecedoresBizServices)
		{
			_ifornecedoresBizServices = fornecedoresBizServices;
		}

		// GET: api/<FornecedoresController>
		[HttpGet]
		public List<FornecedoresTO> Get()
		{
			try
			{
				return _ifornecedoresBizServices.GetFornecedoress();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET api/<FornecedoresController>/5
		[HttpGet("{id}")]
		public FornecedoresTO Get(int id)
		{
			try
			{
				return _ifornecedoresBizServices.GetFornecedoresById(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// POST api/<FornecedoresController>
		[HttpPost]
		public void Post([FromBody] FornecedoresTO FornecedoresDTO)
		{
			try
			{
				_ifornecedoresBizServices.CreateFornecedores(FornecedoresDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// PUT api/<FornecedoresController>/5
		[HttpPut]
		public void Put([FromBody] FornecedoresTO FornecedoresDTO)
		{
			try
			{
				_ifornecedoresBizServices.UpdateFornecedores(FornecedoresDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE api/<FornecedoresController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			try
			{
				_ifornecedoresBizServices.DeleteFornecedores(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
