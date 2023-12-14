using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AntonioMeireles.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Usuario_ClienteId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Vendedor_VendedorId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_NotaDeVenda_NotaDeVendaId",
                table: "Pagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_NotaDeVenda_NotaDeVendaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_NotaDeVendaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Produto");

            migrationBuilder.AlterColumn<int>(
                name: "NotaDeVendaId",
                table: "Pagamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "NotaDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TransportadoraId",
                table: "NotaDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoDePagamentoId",
                table: "NotaDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "NotaDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TiposDePagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda",
                column: "TransportadoraId",
                principalTable: "Transportadora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Usuario_ClienteId",
                table: "NotaDeVenda",
                column: "ClienteId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Vendedor_VendedorId",
                table: "NotaDeVenda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_NotaDeVenda_NotaDeVendaId",
                table: "Pagamentos",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Usuario_ClienteId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Vendedor_VendedorId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_NotaDeVenda_NotaDeVendaId",
                table: "Pagamentos");

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Produto",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NotaDeVendaId",
                table: "Pagamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "NotaDeVenda",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TransportadoraId",
                table: "NotaDeVenda",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TipoDePagamentoId",
                table: "NotaDeVenda",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "NotaDeVenda",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_NotaDeVendaId",
                table: "Produto",
                column: "NotaDeVendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TiposDePagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda",
                column: "TransportadoraId",
                principalTable: "Transportadora",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Usuario_ClienteId",
                table: "NotaDeVenda",
                column: "ClienteId",
                principalTable: "Usuario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Vendedor_VendedorId",
                table: "NotaDeVenda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_NotaDeVenda_NotaDeVendaId",
                table: "Pagamentos",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_NotaDeVenda_NotaDeVendaId",
                table: "Produto",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id");
        }
    }
}
