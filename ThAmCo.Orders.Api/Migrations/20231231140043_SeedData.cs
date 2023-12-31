using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Orders.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Notes", "Status", "SubmittedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "Please deliver to garage", 0, new DateTime(2023, 7, 22, 10, 30, 10, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 10, 30, 10, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "Leave at front desk", 1, new DateTime(2023, 7, 23, 11, 15, 30, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 23, 11, 15, 30, 0, DateTimeKind.Unspecified) },
                    { 3, 3, "Ring bell on arrival", 2, new DateTime(2023, 7, 24, 12, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 24, 12, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, "Contact on mobile before delivery", 0, new DateTime(2023, 7, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 25, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, "Deliver after 5 PM", 1, new DateTime(2023, 7, 26, 14, 20, 10, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 26, 14, 20, 10, 0, DateTimeKind.Unspecified) },
                    { 6, 6, "Gate code is 1234", 2, new DateTime(2023, 7, 27, 10, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 27, 10, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, "No signature required", 0, new DateTime(2023, 7, 28, 16, 5, 20, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 28, 16, 5, 20, 0, DateTimeKind.Unspecified) },
                    { 8, 8, "Call on arrival, allergic to dogs", 1, new DateTime(2023, 7, 29, 13, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 29, 13, 30, 45, 0, DateTimeKind.Unspecified) },
                    { 9, 9, "Urgent delivery requested", 2, new DateTime(2023, 7, 30, 8, 15, 15, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 30, 8, 15, 15, 0, DateTimeKind.Unspecified) },
                    { 10, 10, "Please package discreetly", 0, new DateTime(2023, 7, 31, 17, 40, 5, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 31, 17, 40, 5, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Lamp that is very super cool", "Standing Lamp" },
                    { 2, "A case for your books", "Bookcase" },
                    { 3, "Comfortable and adjustable chair perfect for long working hours", "Ergonomic Chair" },
                    { 4, "Sleek and responsive keyboard with long battery life", "Wireless Keyboard" },
                    { 5, "High-quality audio with noise cancellation feature", "Bluetooth Headphones" },
                    { 6, "Stylish watch with fitness tracking and notifications", "Smart Watch" },
                    { 7, "Insulated bottle to keep your drinks hot or cold for hours", "Water Bottle" },
                    { 8, "Durable and spacious backpack, ideal for travel or daily use", "Backpack" },
                    { 9, "Elegant lamp with adjustable brightness for reading or work", "Table Lamp" },
                    { 10, "Keep your workspace tidy with this multi-compartment organiser", "Desk Organiser" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 10, 10.32 },
                    { 2, 1, 3, 1, 200.0 },
                    { 4, 2, 4, 2, 22.0 },
                    { 5, 2, 5, 1, 50.0 },
                    { 6, 3, 6, 3, 35.75 },
                    { 7, 3, 7, 2, 18.199999999999999 },
                    { 8, 3, 1, 1, 10.32 },
                    { 9, 4, 8, 1, 42.5 },
                    { 10, 5, 9, 2, 55.0 },
                    { 11, 5, 3, 1, 200.0 },
                    { 12, 6, 10, 4, 60.0 },
                    { 13, 7, 2, 3, 15.5 },
                    { 14, 7, 4, 1, 22.0 },
                    { 15, 7, 6, 2, 35.75 },
                    { 16, 8, 5, 1, 50.0 },
                    { 17, 8, 7, 1, 18.199999999999999 },
                    { 18, 9, 1, 2, 10.32 },
                    { 19, 9, 8, 1, 42.5 },
                    { 20, 9, 10, 3, 60.0 },
                    { 21, 10, 9, 1, 55.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
