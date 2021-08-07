namespace CadastroClientes.Controllers
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.TO;
	using Microsoft.AspNetCore.Mvc;
	using System;
	using System.Collections.Generic;

	[Route("api/[controller]")]
	[ApiController]
	public class EnderecoController : ControllerBase
	{
		private readonly IEnderecoBizServices _iEnderecoBizServices;

		public EnderecoController(IEnderecoBizServices ienderecoBizServices)
		{
			_iEnderecoBizServices = ienderecoBizServices;
		}

		// GET: api/<EnderecoController>
		[HttpGet]
		public List<EnderecoTO> Get()
		{
			return _iEnderecoBizServices.GetEnderecos();
		}

		// GET api/<EnderecoController>/5
		[HttpGet("{id}")]
		public EnderecoTO Get(int id)
		{
			try
			{
				return _iEnderecoBizServices.GetEnderecoById(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// POST api/<EnderecoController>
		[HttpPost]
		public void Post([FromBody] EnderecoTO enderecoDTO)
		{
			try
			{
				_iEnderecoBizServices.CreateEndereco(enderecoDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		// PUT api/<EnderecoController>/5
		[HttpPut]
		public void Put([FromBody] EnderecoTO enderecoDTO)
		{
			try
			{
				_iEnderecoBizServices.UpdateEndereco(enderecoDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE api/<EnderecoController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_iEnderecoBizServices.DeleteEnderco(id);
		}
	}
}
