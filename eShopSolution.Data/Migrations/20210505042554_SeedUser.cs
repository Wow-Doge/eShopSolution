using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 5, 11, 25, 53, 560, DateTimeKind.Local).AddTicks(6326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 5, 11, 24, 29, 674, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("f4152dda-a256-49a6-9003-82aac1ab94df"), "1d172160-43ba-4675-b806-3c3131d3e917", "Admin role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f4152dda-a256-49a6-9003-82aac1ab94df"), new Guid("2acd7f0f-cefa-4c80-8db3-874f1b3207c7") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2acd7f0f-cefa-4c80-8db3-874f1b3207c7"), 0, "f225f42a-fbac-41a9-a631-50bbfad72ec4", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "duynt1651998@gmail.com", true, "ABCD", "XYZW", false, null, "duynt1651998@gmail.com", "admin", "AQAAAAEAACcQAAAAEPD1Ds8eq3yZY3NKcxkwyNf8v2Sn+7c0ENiXhdgvXufq6auk/qe0zXu8i2pS8nnUTA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 11, 25, 53, 582, DateTimeKind.Local).AddTicks(4186));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f4152dda-a256-49a6-9003-82aac1ab94df"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f4152dda-a256-49a6-9003-82aac1ab94df"), new Guid("2acd7f0f-cefa-4c80-8db3-874f1b3207c7") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2acd7f0f-cefa-4c80-8db3-874f1b3207c7"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 5, 11, 24, 29, 674, DateTimeKind.Local).AddTicks(7058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 5, 11, 25, 53, 560, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 5, 11, 24, 29, 696, DateTimeKind.Local).AddTicks(9402));
        }
    }
}
