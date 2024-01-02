﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThAmCo.Orders.Api.Migrations {
    /// <inheritdoc />
    public partial class OrderSubmittedDate : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Orders",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Orders");
        }
    }
}
