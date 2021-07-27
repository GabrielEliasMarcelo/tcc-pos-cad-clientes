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
	public class PessoaFisicaController : ControllerBase
	{
		private readonly IPessoaFisicaBizService _iPessoaFisicaBizService;

		public PessoaFisicaController(IPessoaFisicaBizService pessoaFisicaBizService)
		{
			_iPessoaFisicaBizService = pessoaFisicaBizService;
		}

		// GET: api/<PessoaFisicaController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<PessoaFisicaController>/5
		[HttpGet("{id}")]
		public PessoaFisicaDTO Get(int id)
		{
			try
			{
				return _iPessoaFisicaBizService.GetPessoaFisicaById(id).ToPfDTO();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// POST api/<PessoaFisicaController>
		[HttpPost]
		public void Post([FromBody] PessoaFisicaDTO pessoaFisicaDTO)
		{

		}

		// PUT api/<PessoaFisicaController>/5
		[HttpPut]
		public void Put([FromBody] PessoaFisicaDTO pessoaFisicaDTO)
		{
		}

		// DELETE api/<PessoaFisicaController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
