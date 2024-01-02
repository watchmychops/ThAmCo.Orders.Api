using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThAmCo.Orders.Api.Migrations {
    /// <inheritdoc />
    public partial class SeedData : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) {

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
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 10, 10.32m },
                    { 2, 1, 3, 1, 200.00m },
                    { 4, 2, 4, 2, 22.00m },
                    { 5, 2, 5, 1, 50.00m },
                    { 6, 3, 6, 3, 35.75m },
                    { 7, 3, 7, 2, 18.20m },
                    { 8, 3, 1, 1, 10.32m },
                    { 9, 4, 8, 1, 42.50m },
                    { 10, 5, 9, 2, 55.00m },
                    { 11, 5, 3, 1, 200.00m },
                    { 12, 6, 10, 4, 60.00m },
                    { 13, 7, 2, 3, 15.50m },
                    { 14, 7, 4, 1, 22.00m },
                    { 15, 7, 6, 2, 35.75m },
                    { 16, 8, 5, 1, 50.00m },
                    { 17, 8, 7, 1, 18.20m},
                    { 18, 9, 1, 2, 10.32m },
                    { 19, 9, 8, 1, 42.00m },
                    { 20, 9, 10, 3, 60.00m },
                    { 21, 10, 9, 1, 55.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) {
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");


            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
