using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace lojaComEntity.Migrations
{
    public partial class tiposUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaID", table: "Produto");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Produto_ProdutoID", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Venda_VendaID", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_Venda_Usuario_ClienteID", table: "Venda");
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuario",
                nullable: false,
                defaultValue: "");
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Usuario",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Usuario",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaID",
                table: "Produto",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Produto_ProdutoID",
                table: "ProdutoVenda",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Venda_VendaID",
                table: "ProdutoVenda",
                column: "VendaID",
                principalTable: "Venda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_ClienteID",
                table: "Venda",
                column: "ClienteID",
                principalTable: "Usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaID", table: "Produto");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Produto_ProdutoID", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_ProdutoVenda_Venda_VendaID", table: "ProdutoVenda");
            migrationBuilder.DropForeignKey(name: "FK_Venda_Usuario_ClienteID", table: "Venda");
            migrationBuilder.DropColumn(name: "Discriminator", table: "Usuario");
            migrationBuilder.DropColumn(name: "CPF", table: "Usuario");
            migrationBuilder.DropColumn(name: "CNPJ", table: "Usuario");
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaID",
                table: "Produto",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Produto_ProdutoID",
                table: "ProdutoVenda",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoVenda_Venda_VendaID",
                table: "ProdutoVenda",
                column: "VendaID",
                principalTable: "Venda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_ClienteID",
                table: "Venda",
                column: "ClienteID",
                principalTable: "Usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
