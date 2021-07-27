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
		private readonly IEnderecoBizServices _iEnderecoBizServices;

		public EnderecoController(IEnderecoBizServices ienderecoBizServices)
		{
			_iEnderecoBizServices = ienderecoBizServices;
		}

		// GET: api/<EnderecoController>
		[HttpGet]
		public List<EnderecoDTO> Get()
		{
			return _iEnderecoBizServices.GetEnderecos().ToDto();
		}

		// GET api/<EnderecoController>/5
		[HttpGet("{id}")]
		public EnderecoDTO Get(int id)
		{
			try
			{
				return _iEnderecoBizServices.GetEnderecoById(id).ToDto();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// POST api/<EnderecoController>
		[HttpPost]
		public void Post([FromBody] EnderecoDTO enderecoDTO)
		{
			try
			{
				_iEnderecoBizServices.CreateEndereco(enderecoDTO.ToEnderecoTO());
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		// PUT api/<EnderecoController>/5
		[HttpPut]
		public void Put([FromBody] EnderecoDTO enderecoDTO)
		{
			try
			{
				_iEnderecoBizServices.UpdateEndereco(enderecoDTO.ToEnderecoTO());
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
