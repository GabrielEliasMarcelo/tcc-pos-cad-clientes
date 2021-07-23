namespace CadastroClientes.Controllers
{
	using CadastroClientes.DTO;
	using CadastroClientes.Extensions;
	using CadastroClientesServices.BizServices.Interface;
	using Microsoft.AspNetCore.Mvc;
	using System;
	using System.Collections.Generic;

	[Route("api/[controller]")]
	[ApiController]
	public class EnderecoController : ControllerBase
	{
		private readonly IEnderecoBizServices _ienderecoBizServices;

		public EnderecoController(IEnderecoBizServices ienderecoBizServices)
		{
			_ienderecoBizServices = ienderecoBizServices;
		}

		// GET: api/<EnderecoController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<EnderecoController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<EnderecoController>
		[HttpPost]
		public void Post([FromBody] EnderecoDTO enderecoDTO)
		{
			try
			{
				_ienderecoBizServices.CreateEndereco(enderecoDTO.ToEndereco());
			}
			catch (Exception ex)
			{
				throw ex;
			}
			
		}

		// PUT api/<EnderecoController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<EnderecoController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
