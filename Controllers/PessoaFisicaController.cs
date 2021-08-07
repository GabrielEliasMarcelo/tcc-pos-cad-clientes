namespace CadastroClientes.Controllers
{
	using CadastroClientesServices.BizServices.Interface;
	using CadastroClientesServices.TO;
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
		public List<PessoaFisicaTO> Get()
		{
			try
			{
				return _iPessoaFisicaBizService.GetPessoasFisica();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET api/<PessoaFisicaController>/5
		[HttpGet("{id}")]
		public PessoaFisicaTO Get(int id)
		{
			try
			{
				return _iPessoaFisicaBizService.GetPessoaFisicaById(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// POST api/<PessoaFisicaController>
		[HttpPost]
		public void Post([FromBody] PessoaFisicaTO pessoaFisicaDTO)
		{
			try
			{
				_iPessoaFisicaBizService.CreatePessoaFisica(pessoaFisicaDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// PUT api/<PessoaFisicaController>/5
		[HttpPut]
		public void Put([FromBody] PessoaFisicaTO pessoaFisicaDTO)
		{
			try
			{
				_iPessoaFisicaBizService.UpdatePessoaFisica(pessoaFisicaDTO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE api/<PessoaFisicaController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			try
			{
				_iPessoaFisicaBizService.DeletePessoaFisica(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
