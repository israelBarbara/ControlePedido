using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlePedido.Infrastructure.Migrations
{
    public partial class itemPedidoTbName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_PEDIDO_PedidoId",
                table: "ItemPedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPedido",
                table: "ItemPedido");

            migrationBuilder.RenameTable(
                name: "ItemPedido",
                newName: "ITEMPEDIDO");

            migrationBuilder.RenameIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ITEMPEDIDO",
                newName: "IX_ITEMPEDIDO_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEMPEDIDO",
                table: "ITEMPEDIDO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ITEMPEDIDO_PEDIDO_PedidoId",
                table: "ITEMPEDIDO",
                column: "PedidoId",
                principalTable: "PEDIDO",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ITEMPEDIDO_PEDIDO_PedidoId",
                table: "ITEMPEDIDO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEMPEDIDO",
                table: "ITEMPEDIDO");

            migrationBuilder.RenameTable(
                name: "ITEMPEDIDO",
                newName: "ItemPedido");

            migrationBuilder.RenameIndex(
                name: "IX_ITEMPEDIDO_PedidoId",
                table: "ItemPedido",
                newName: "IX_ItemPedido_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPedido",
                table: "ItemPedido",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_PEDIDO_PedidoId",
                table: "ItemPedido",
                column: "PedidoId",
                principalTable: "PEDIDO",
                principalColumn: "Id");
        }
    }
}
