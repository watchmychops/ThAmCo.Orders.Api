using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThAmCo.Orders.Api.Migrations
{
    /// <inheritdoc />
    public partial class FixedDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_DescriptionId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_DescriptionId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_DescriptionId",
                table: "Product",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_DescriptionId",
                table: "Product",
                column: "DescriptionId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
