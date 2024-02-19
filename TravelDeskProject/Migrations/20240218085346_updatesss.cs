using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class updatesss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MealPreferenceId",
                table: "Requests",
                newName: "MealPreferenceTypeId");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3093));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MealPreferenceTypeId",
                table: "Requests",
                newName: "MealPreferenceId");

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
    }
}
