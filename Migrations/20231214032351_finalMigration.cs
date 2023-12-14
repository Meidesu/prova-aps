using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AntonioMeireles.Migrations
{
    public partial class finalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Usuario_ClienteId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_NotaDeVenda_NotaDeVendaId",
                table: "Pagamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposDePagamento",
                table: "TiposDePagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagamentos",
                table: "Pagamentos");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "TiposDePagamento",
                newName: "TipoDePagamento");

            migrationBuilder.RenameTable(
                name: "Pagamentos",
                newName: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "TipoPagamento",
                table: "TipoDePagamento",
                newName: "Discriminator");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamentos_NotaDeVendaId",
                table: "Pagamento",
                newName: "IX_Pagamento_NotaDeVendaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDePagamento",
                table: "TipoDePagamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Cliente_ClienteId",
                table: "NotaDeVenda",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TipoDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TipoDePagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_NotaDeVenda_NotaDeVendaId",
                table: "Pagamento",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Cliente_ClienteId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TipoDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_NotaDeVenda_NotaDeVendaId",
                table: "Pagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDePagamento",
                table: "TipoDePagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "TipoDePagamento",
                newName: "TiposDePagamento");

            migrationBuilder.RenameTable(
                name: "Pagamento",
                newName: "Pagamentos");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "TiposDePagamento",
                newName: "TipoPagamento");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamento_NotaDeVendaId",
                table: "Pagamentos",
                newName: "IX_Pagamentos_NotaDeVendaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposDePagamento",
                table: "TiposDePagamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagamentos",
                table: "Pagamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TiposDePagamento",
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
                name: "FK_Pagamentos_NotaDeVenda_NotaDeVendaId",
                table: "Pagamentos",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
