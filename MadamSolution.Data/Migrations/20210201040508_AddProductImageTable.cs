using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MadamSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 2, 1, 8, 23, 51, 456, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
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
                defaultValue: new DateTime(2021, 2, 1, 8, 23, 51, 456, DateTimeKind.Local).AddTicks(1054),
                oldClrType: typeof(DateTime));

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8"),
                column: "ConcurrencyStamp",
                value: "7e0665cd-78a8-4865-852a-dfe9b67ad35a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1f8f165-1db8-4359-892f-251cdecb2d70", "AQAAAAEAACcQAAAAEE4sVW1s0f4z2x4ORiTgYR0Potz6R7YKM8I9aCyIM0ma8jeU4yDf9XYiNNBR/7N5dA==" });
        }
    }
}
