using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Repository.Migrations
{
    public partial class realitonadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Todos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Added", "CreatedDate", "DueTo" },
                values: new object[] { new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5162), new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5177), new DateTime(2022, 8, 25, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Added", "CreatedDate", "DueTo" },
                values: new object[] { new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5178), new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5180), new DateTime(2022, 9, 4, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 15, 23, 20, 42, 118, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId",
                table: "Todos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Users_UserId",
                table: "Todos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Users_UserId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Added", "DueTo" },
                values: new object[] { new DateTime(2022, 8, 15, 21, 4, 28, 596, DateTimeKind.Local).AddTicks(2795), new DateTime(2022, 8, 25, 21, 4, 28, 596, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Added", "DueTo" },
                values: new object[] { new DateTime(2022, 8, 15, 21, 4, 28, 596, DateTimeKind.Local).AddTicks(2822), new DateTime(2022, 9, 4, 21, 4, 28, 596, DateTimeKind.Local).AddTicks(2823) });
        }
    }
}
