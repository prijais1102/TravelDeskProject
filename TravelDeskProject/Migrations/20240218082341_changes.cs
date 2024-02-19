using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Bookings",
                newName: "BookingTypeId");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 13, 53, 41, 40, DateTimeKind.Local).AddTicks(5048));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookingTypeId",
                table: "Bookings",
                newName: "BookingId");

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
    }
}
