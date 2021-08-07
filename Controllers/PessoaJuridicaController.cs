namespace CadastroClientes.Controllers
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.TO;
	using Microsoft.AspNetCore.Mvc;
	using System;
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
		public List<PessoaJuridicaTO> Get()
		{
			try
			{
				return _iPessoaJuridicaBizService.GetPessoaJuridica();
			}
			catch (Exception ex)
			{ 
				throw ex;
			}
		}

		// GET api/<PessoaJuridicaController>/5
		[HttpGet("{id}")]
		public PessoaJuridicaTO Get(int id)
		{
			try
			{
				return _iPessoaJuridicaBizService.GetPessoaJuridicaById(id);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		// POST api/<PessoaJuridicaController>
		[HttpPost]
		public void Post([FromBody] PessoaJuridicaTO value)
		{
			try
			{
				_iPessoaJuridicaBizService.CreatePessoaJuridica(value);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// PUT api/<PessoaJuridicaController>/5
		[HttpPut]
		public void Put([FromBody] PessoaJuridicaTO value)
		{
			try
			{
				_iPessoaJuridicaBizService.UpdatePessoaJuridica(value);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE api/<PessoaJuridicaController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			try
			{
				_iPessoaJuridicaBizService.DeletePessoaJuridica(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
