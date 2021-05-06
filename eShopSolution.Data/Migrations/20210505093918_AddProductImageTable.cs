using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 5, 11, 25, 53, 560, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f4152dda-a256-49a6-9003-82aac1ab94df"),
                column: "ConcurrencyStamp",
                value: "e7556d96-3737-4e36-9061-706c31627789");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2acd7f0f-cefa-4c80-8db3-874f1b3207c7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b099efa6-2283-4310-b9d8-1784be25e73e", "AQAAAAEAACcQAAAAEMsZKbK/ZZxKjP7V4Z8ad1FCuqJytoxCU3SaivH75YRFBUBHg9WYq3X8FxwRUciGyw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 16, 39, 17, 934, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 5, 11, 25, 53, 560, DateTimeKind.Local).AddTicks(6326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f4152dda-a256-49a6-9003-82aac1ab94df"),
                column: "ConcurrencyStamp",
                value: "1d172160-43ba-4675-b806-3c3131d3e917");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2acd7f0f-cefa-4c80-8db3-874f1b3207c7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f225f42a-fbac-41a9-a631-50bbfad72ec4", "AQAAAAEAACcQAAAAEPD1Ds8eq3yZY3NKcxkwyNf8v2Sn+7c0ENiXhdgvXufq6auk/qe0zXu8i2pS8nnUTA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 11, 25, 53, 582, DateTimeKind.Local).AddTicks(4186));
        }
    }
}
