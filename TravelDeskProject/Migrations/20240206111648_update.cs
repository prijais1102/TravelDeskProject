using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RoleId" },
                values: new object[] { new DateTime(2024, 2, 6, 16, 46, 47, 673, DateTimeKind.Local).AddTicks(2354), 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RoleId" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3727), 3 });
        }
    }
}
