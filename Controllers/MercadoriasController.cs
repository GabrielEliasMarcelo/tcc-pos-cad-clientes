namespace CadastroClientes.Controllers
{
    using CadastroClientesServices.BizServices.Interface;
    using CadastroClientesServices.TO;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class MercadoriasController : Controller
    {
        private readonly IMercadoriasBizServices _imercadoriasBizServices;

        public MercadoriasController(IMercadoriasBizServices mercadoriasBizServices)
        {
            _imercadoriasBizServices = mercadoriasBizServices;
        }

		// GET: api/<MercadoriasController>
		[HttpGet]
		public List<MercadoriasTO> Get()
		{
			try
			{
				return _imercadoriasBizServices.GetMercadoriass();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET api/<MercadoriasController>/5
		[HttpGet("{id}")]
		public MercadoriasTO Get(int id)
		{
			try
			{
				return _imercadoriasBizServices.GetMercadoriasById(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// POST api/<MercadoriasController>
		[HttpPost]
		public void Post([FromBody] MercadoriasTO MercadoriasDTO)
		{
			try
			{
				_imercadoriasBizServices.CreateMercadorias(MercadoriasDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// PUT api/<MercadoriasController>/5
		[HttpPut]
		public void Put([FromBody] MercadoriasTO MercadoriasDTO)
		{
			try
			{
				_imercadoriasBizServices.UpdateMercadorias(MercadoriasDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE api/<MercadoriasController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			try
			{
				_imercadoriasBizServices.DeleteMercadorias(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
