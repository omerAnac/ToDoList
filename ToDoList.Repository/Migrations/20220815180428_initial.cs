using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", maxLength: 450, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    Added = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Added", "Content", "DueTo", "IsDone", "Title", "UserId" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 21, 4, 28, 596, DateTimeKind.Local).AddTicks(2795), "falan filanda zımpırtı yapılacak", new DateTime(2022, 8, 25, 21, 4, 28, 596, DateTimeKind.Local).AddTicks(2811), false, "Yapılacak 2", 1 });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Added", "Content", "DueTo", "IsDone", "Title", "UserId" },
                values: new object[] { 2, new DateTime(2022, 8, 15, 21, 4, 28, 596, DateTimeKind.Local).AddTicks(2822), "falan filanda zımpırtı yapılacak", new DateTime(2022, 9, 4, 21, 4, 28, 596, DateTimeKind.Local).AddTicks(2823), false, "Yapılacak 2", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "abc.123", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
