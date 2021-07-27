namespace CadastroClientes.Extensions
{
	using CadastroClientes.DTO;
	using CadastroClientesServices.TO;

	public static class PessoaFisicaExtension
	{
		public static PessoaFisicaDTO ToPfDTO(this PessoaFisicaTO pessoaFisicaTO)
		{
			PessoaFisicaDTO pessoaFisicaDTO = new PessoaFisicaDTO();
			return pessoaFisicaDTO;
		}
	}
}
