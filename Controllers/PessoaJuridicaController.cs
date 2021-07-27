namespace CadastroClientes.Controllers
{
	using CadastroClientesServices.BizServices.Interface;
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;

	[Route("api/[controller]")]
	[ApiController]
	public class PessoaJuridicaController : ControllerBase
	{
		private readonly IPessoaJuridicaBizService _iPessoaJuridicaBizService;

		public PessoaJuridicaController(IPessoaJuridicaBizService pessoaJuridicaBizService)
		{
			_iPessoaJuridicaBizService = pessoaJuridicaBizService;
		}

		// GET: api/<PessoaJuridicaController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<PessoaJuridicaController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<PessoaJuridicaController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<PessoaJuridicaController>/5
		[HttpPut]
		public void Put([FromBody] string value)
		{
		}

		// DELETE api/<PessoaJuridicaController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
