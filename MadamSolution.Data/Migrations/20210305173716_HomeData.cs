using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MadamSolution.Data.Migrations
{
    public partial class HomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Url = table.Column<string>(maxLength: 200, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Image = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
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
                value: new DateTime(2021, 3, 6, 0, 37, 15, 324, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8"),
                column: "ConcurrencyStamp",
                value: "79739f3c-5498-473d-9505-77b0f2cb84aa");

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Description", "Image", "Name", "SortOrder", "Status", "Url" },
                values: new object[,]
                {
                    { 1, "Hàng chất lượng mà giá cả lại phải chăng tốt nhất thị trường", "/themes/images/carousel/1.png", "Thời trang nữ cao cấp", 1, 1, "#" },
                    { 2, "Hàng chất lượng mà giá cả lại phải chăng tốt nhất thị trường", "/themes/images/carousel/2.png", "Thời trang nữ cao cấp", 2, 1, "#" },
                    { 3, "Hàng chất lượng mà giá cả lại phải chăng tốt nhất thị trường", "/themes/images/carousel/3.png", "Thời trang nữ cao cấp", 3, 1, "#" },
                    { 4, "Hàng chất lượng mà giá cả lại phải chăng tốt nhất thị trường", "/themes/images/carousel/4.png", "Thời trang nữ cao cấp", 4, 1, "#" },
                    { 5, "Hàng chất lượng mà giá cả lại phải chăng tốt nhất thị trường", "/themes/images/carousel/5.png", "Thời trang nữ cao cấp", 5, 1, "#" },
                    { 6, "Hàng chất lượng mà giá cả lại phải chăng tốt nhất thị trường", "/themes/images/carousel/6.png", "Thời trang nữ cao cấp", 6, 1, "#" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "989c076b-0e41-43e5-8159-e07ebb6cb5a9", "AQAAAAEAACcQAAAAEDqp7A19c1+K6utcyiPbER3aKvDRFajlEeuvvxWQcmhGORnDJUfvQlet1UNVcalQKg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

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
                value: new DateTime(2021, 3, 4, 3, 45, 47, 262, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("223f4c1d-fa90-4c3e-9bee-6d29c7be76a8"),
                column: "ConcurrencyStamp",
                value: "b55ecf6e-aad7-4439-8263-45e7ac53ccfd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0381e29-f86d-4377-8661-8186912b8fe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d95e88d-071b-4bcc-8416-5005384aad91", "AQAAAAEAACcQAAAAEGrrB9A2vkGebUcZElM7Q3xWoSepl+LhIiL3yC9DAtI/3OPr5WeUvI0vW7NLSM+6oA==" });
        }
    }
}
