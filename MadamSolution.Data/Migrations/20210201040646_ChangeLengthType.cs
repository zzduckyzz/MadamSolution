using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MadamSolution.Data.Migrations
{
    public partial class ChangeLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: new DateTime(2021, 2, 1, 11, 6, 45, 355, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8"),
                column: "ConcurrencyStamp",
                value: "23f8914e-d059-4cdd-a68b-cc6d824371a7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5f6b0d2-e730-442c-8b32-c23cc20ed2e5", "AQAAAAEAACcQAAAAEEtVOPV4aqgCbRsGxsw+CzfQ3HEeiDxbRiT45B940qeq7asLACxj5fBVQMtFY6qpYg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: new DateTime(2021, 2, 1, 11, 5, 8, 266, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8"),
                column: "ConcurrencyStamp",
                value: "6489a78b-faeb-4e0d-8ad2-a725271a2750");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a19fd63d-d0e6-4e22-851f-f1f99a400904", "AQAAAAEAACcQAAAAELdqGMY3DpOn++WkL7azzCrIWZNMzDECQIZKuGWIQ9Q0gJ+35OAsWrAcMZ9iV0kZOA==" });
        }
    }
}
