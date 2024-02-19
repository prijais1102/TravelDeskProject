using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class updatess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HotelLocationId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "commentsFromHR",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "commentsFromManager",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 16, 12, 36, 53, 276, DateTimeKind.Local).AddTicks(4373));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "commentsFromHR",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "commentsFromManager",
                table: "Requests");

            migrationBuilder.AlterColumn<int>(
                name: "HotelLocationId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7057));
        }
    }
}
