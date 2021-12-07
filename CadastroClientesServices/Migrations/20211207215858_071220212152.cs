using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroClientesServices.Migrations
{
    public partial class _071220212152 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DadosComplementares = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPessoaFisica = table.Column<int>(type: "int", nullable: true),
                    IdPessoaJuridica = table.Column<int>(type: "int", nullable: true),
                    IdEndereco = table.Column<int>(type: "int", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Enderecos_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fornecedores_PessoaFisicas_IdPessoaFisica",
                        column: x => x.IdPessoaFisica,
                        principalTable: "PessoaFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fornecedores_PessoaJuridicas_IdPessoaJuridica",
                        column: x => x.IdPessoaJuridica,
                        principalTable: "PessoaJuridicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mercadorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercadorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depositos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdMercadoria = table.Column<int>(type: "int", nullable: false),
                    MercadoriaId = table.Column<int>(type: "int", nullable: true),
                    IdEndereco = table.Column<int>(type: "int", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depositos_Enderecos_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Depositos_Mercadorias_MercadoriaId",
                        column: x => x.MercadoriaId,
                        principalTable: "Mercadorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depositos_IdEndereco",
                table: "Depositos",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Depositos_MercadoriaId",
                table: "Depositos",
                column: "MercadoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_IdEndereco",
                table: "Fornecedores",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_IdPessoaFisica",
                table: "Fornecedores",
                column: "IdPessoaFisica");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_IdPessoaJuridica",
                table: "Fornecedores",
                column: "IdPessoaJuridica");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depositos");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Mercadorias");
        }
    }
}
