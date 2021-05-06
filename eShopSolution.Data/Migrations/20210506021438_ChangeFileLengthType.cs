using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f4152dda-a256-49a6-9003-82aac1ab94df"),
                column: "ConcurrencyStamp",
                value: "c7e66680-632c-4d68-97ed-28012f64ce8d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2acd7f0f-cefa-4c80-8db3-874f1b3207c7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c335ff79-1a1d-4e14-b622-695808053378", "AQAAAAEAACcQAAAAEH/NxNzjRQcXkK1/Gc+UCxNotWmPc/Bem0ltjdD9mVyDB2sE1yX0TUIWiNBZPi987g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 6, 9, 14, 37, 291, DateTimeKind.Local).AddTicks(6892));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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
        }
    }
}
