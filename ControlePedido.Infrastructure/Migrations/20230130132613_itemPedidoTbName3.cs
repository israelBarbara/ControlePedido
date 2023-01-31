using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlePedido.Infrastructure.Migrations
{
    public partial class itemPedidoTbName3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ITEMPEDIDO_PEDIDO_PedidoId",
                table: "ITEMPEDIDO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEMPEDIDO",
                table: "ITEMPEDIDO");

            migrationBuilder.RenameTable(
                name: "ITEMPEDIDO",
                newName: "ITEM_PEDIDO");

            migrationBuilder.RenameIndex(
                name: "IX_ITEMPEDIDO_PedidoId",
                table: "ITEM_PEDIDO",
                newName: "IX_ITEM_PEDIDO_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITEM_PEDIDO",
                table: "ITEM_PEDIDO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ITEM_PEDIDO_PEDIDO_PedidoId",
                table: "ITEM_PEDIDO",
                column: "PedidoId",
                principalTable: "PEDIDO",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ITEM_PEDIDO_PEDIDO_PedidoId",
                table: "ITEM_PEDIDO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITEM_PEDIDO",
                table: "ITEM_PEDIDO");

            migrationBuilder.RenameTable(
                name: "ITEM_PEDIDO",
                newName: "ITEMPEDIDO");

            migrationBuilder.RenameIndex(
                name: "IX_ITEM_PEDIDO_PedidoId",
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
    }
}
