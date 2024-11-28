using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RabbitMqProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class rabbpro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "RabbitMqProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RabbitMqProducts",
                table: "RabbitMqProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RabbitMqProducts",
                table: "RabbitMqProducts");

            migrationBuilder.RenameTable(
                name: "RabbitMqProducts",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");
        }
    }
}
