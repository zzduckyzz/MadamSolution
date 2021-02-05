using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MadamSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 1, 8, 23, 51, 456, DateTimeKind.Local).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 2, 1, 8, 1, 42, 519, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"), new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 1, 8, 23, 51, 471, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8"), "7e0665cd-78a8-4865-852a-dfe9b67ad35a", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"), 0, "a1f8f165-1db8-4359-892f-251cdecb2d70", new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "duc.phamminh94@gmail.com", true, "Duc", "Pham", false, null, "duc.phamminh94@gmail.com", "admin", "AQAAAAEAACcQAAAAEE4sVW1s0f4z2x4ORiTgYR0Potz6R7YKM8I9aCyIM0ma8jeU4yDf9XYiNNBR/7N5dA==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"), new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 1, 8, 1, 42, 519, DateTimeKind.Local).AddTicks(4375),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 1, 8, 23, 51, 456, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 1, 8, 1, 42, 536, DateTimeKind.Local).AddTicks(3426));
        }
    }
}
