using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedOn", "RoleName" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3694), "Admin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RoleName" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3695), "HRAdmin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "RoleName" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3696), "Employee" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreateBy", "CreatedOn", "IsActive", "RoleName", "UpdateBy", "UpdatedOn" },
                values: new object[] { 4, 0, new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3697), false, "Manager", null, null });

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
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 56, 44, 969, DateTimeKind.Local).AddTicks(3727));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 54, 3, 844, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 54, 3, 844, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 54, 3, 844, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "RoleName" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 54, 3, 844, DateTimeKind.Local).AddTicks(3637), "IT" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RoleName" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 54, 3, 844, DateTimeKind.Local).AddTicks(3639), "Sales" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "RoleName" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 54, 3, 844, DateTimeKind.Local).AddTicks(3640), "HR" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 54, 3, 844, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 6, 14, 54, 3, 844, DateTimeKind.Local).AddTicks(3668));
        }
    }
}
